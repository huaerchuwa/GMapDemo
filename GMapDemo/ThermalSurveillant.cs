using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMapDemo
{
    public class ThermalSurveillant
    {
        #region Private Fields

        /// <summary>
        /// 是否停止线程，此变量供多个线程访问。
        /// </summary>
        private volatile bool shouldStop = false;

        #endregion
        #region Public Properties

        #endregion
        #region Public Events

        /// <summary>
        /// 帧刷新事件。
        /// </summary>
        public EventHandler<FrameRefreshEventArgs> FrameRefresh;

        /// <summary>
        /// 播放完成。
        /// </summary>
        public EventHandler<CompletedEventArgs> Completed;

        #endregion
        #region Protected Methods

        /// <summary>
        /// 处理帧刷新事件。
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnFrameRefresh(FrameRefreshEventArgs e)
        {
            if (this.FrameRefresh != null)
            {
                this.FrameRefresh(this, e);
            }
        }

        /// <summary>
        /// 处理视频读完事件。
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnCompleted(CompletedEventArgs e)
        {
            if (this.Completed != null)
            {
                this.Completed(this, e);
            }
        }

        #endregion
        #region Public Methods

        /// <summary>
        /// 视频监控。
        /// </summary>
        /// <param name="capture">捕捉。</param>
        public void DoSurveillance(Object oCapture)
        {
            Capture capture = oCapture as Capture;
            int id = 1;
            if (capture == null)
            {
                throw new InvalidCaptureObjectException("传递的Capture类型无效。");
            }
            while (!shouldStop)
            {
                Image<Bgr, byte> frame = capture.QueryFrame();
                if (frame != null)
                {
                    FrameRefreshEventArgs e = new FrameRefreshEventArgs(frame.ToBitmap(), id++);
                    // 触发刷新事件
                    this.OnFrameRefresh(e);
                }
                else
                {
                    break;
                }
            }
            // 触发完成事件
            this.OnCompleted(new CompletedEventArgs(id));
        }

        /// <summary>
        /// 请求停止线程。
        /// </summary>
        public void Cancel()
        {
            this.shouldStop = true;
        }

        #endregion
    }
}
