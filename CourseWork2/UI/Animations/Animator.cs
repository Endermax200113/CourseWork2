using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace UI.Animations
{
    public static class Animator
    {
        public static List<Animation> AnimationList = new List<Animation>();
        private static Thread _animatorThread;
        private static double _interval;
        public static bool IsWork = false;

        public static int Count()
        {
            return AnimationList.Count;
        }

        public static void Start()
        {
            IsWork = true;
            _interval = 15;
            _animatorThread = new Thread(AnimationInvoker)
            {
                IsBackground = true,
                Name = "UI Animation"
            };

            _animatorThread.Start();
        }

        public static void AnimationInvoker()
        {
            while (true)
            {
                AnimationList.RemoveAll(a => a.Status == Animation.AnimationStatus.Completed);

                Parallel.For(0, Count(), i =>
                {
                    AnimationList[i].UpdateFrame();
                });

                Thread.Sleep((int)_interval);
            }
        }

        public static void Request(Animation anim, bool replaceIfExists)
        {
            anim.Status = Animation.AnimationStatus.Requested;
            Animation dupAnim = GetDuplicate(anim);

            if (dupAnim != null)
            {
                if (replaceIfExists)
                    dupAnim.Status = Animation.AnimationStatus.Completed;
                else return;
            }

            AnimationList.Add(anim);
        }

        private static Animation GetDuplicate(Animation anim)
        {
            return AnimationList.Find(a => a.ID == anim.ID);
        }
    }
}
