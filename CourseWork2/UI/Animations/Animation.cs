using System;

namespace UI.Animations
{
    public class Animation
    {
        public enum AnimationStatus
        {
            Requested, Active, Completed
        }

        public string ID { get; set; }
        public float Value;
        public float StartValue;
        private float _targetValue;
        public float TargetValue
        {
            get => _targetValue;
            set
            {
                _targetValue = value;
                Reverse = value < Value;
            }
        }
        public float Volume;
        public bool Reverse = false;
        public AnimationStatus Status { get; set; }
        private readonly float p15, p30, p70, p85;
        public int StepDivider = 11;

        public Animation() { }

        public Animation(string id, ControlMethod invalidateCtrl, float Value, float targetValue)
        {
            ID = id;
            this.Value = Value;
            TargetValue = targetValue;
            InvalidateControl = invalidateCtrl;

            StartValue = Value;
            Volume = targetValue - Value;

            p15 = ValueByPercent(15);
            p30 = ValueByPercent(30);
            p70 = ValueByPercent(70);
            p85 = ValueByPercent(85);
        }

        public delegate void ControlMethod();
        private ControlMethod InvalidateControl;

        public float Step()
        {
            float basicStep = Math.Abs(Volume) / StepDivider;
            float resultStep;

            if (!Reverse)
            {
                if (Value <= p15 || Value >= p85)
                    resultStep = basicStep / 3.5f;
                else if (Value <= p30 || Value >= p70)
                    resultStep = basicStep / 2f;
                else
                    resultStep = basicStep;
            }
            else
            {
                if (Value >= p15 || Value <= p85)
                    resultStep = basicStep / 3.5f;
                else if (Value >= p30 || Value <= p70)
                    resultStep = basicStep / 2f;
                else
                    resultStep = basicStep;
            }

            return Math.Abs(resultStep);
        }

        private float ValueByPercent(float per)
        {
            float coeff = per / 100;
            float volInPer = Volume * coeff;
            float valueInPer = StartValue + volInPer;

            return valueInPer;
        }

        public void UpdateFrame()
        {
            Status = AnimationStatus.Active;

            if (!Reverse)
            {
                if (Value <= _targetValue)
                {
                    Value += Step();

                    if (Value >= _targetValue)
                    {
                        Value = _targetValue;
                        Status = AnimationStatus.Completed;
                    }
                }
            }
            else
            {
                if (Value >= _targetValue)
                {
                    Value -= Step();

                    if (Value <= _targetValue)
                    {
                        Value = _targetValue;
                        Status = AnimationStatus.Completed;
                    }
                }
            }

            InvalidateControl.Invoke();
        }
    }
}
