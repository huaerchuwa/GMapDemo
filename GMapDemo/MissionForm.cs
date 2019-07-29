using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMapDemo
{
    public partial class MissionForm : Form
    {
        GMapOverlay markers = new GMapOverlay("markers");

        GMapOverlay polygons = new GMapOverlay("polygons");

        GMapOverlay usv_routes = new GMapOverlay("usv_routes");
        GMapRoute usv_groute;
        List<GMapMarker> points_route = new List<GMapMarker>();
        bool animate_path_on = true;
        double cul_lat = 31.929073, cul_lng = 118.769073;

        public MissionForm()
        {
            InitializeComponent();
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            GMapProvider.TimeoutMs = 0;//设置timeoutms为零
            GMapProvider.WebProxy = WebRequest.GetSystemWebProxy();
            GMapProvider.WebProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            GMapProvider.Language = LanguageType.ChineseSimplified;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

            this.MissionMap.MapProvider = GMapProviders.GoogleChinaMap;
            this.MissionMap.MaxZoom = 24;
            this.MissionMap.MinZoom = 0;
            this.MissionMap.Zoom = 12;
            this.MissionMap.ShowCenter = false; //不显示中心十字点
            this.MissionMap.DragButton = System.Windows.Forms.MouseButtons.Left;
            //this.gMapControl.SetPositionByKeywords("上海");
            this.MissionMap.Position = new GMap.NET.PointLatLng(39.923518, 116.539009);
            this.MissionMap.IsAccessible = false;
            GMapProvider.TimeoutMs = 1000;//地图加载完成后设置timeoutms为1000（或者其他大于领零的数值自己尝试0）

            maptest();


        }

        public void maptest()
        {
            //创建一个名为“markers”的图层

            //创建标记，并设置位置及样式
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(39.923518, 116.539009), GMarkerGoogleType.blue_pushpin);
            //将标记添加到图层
            markers.Markers.Add(marker);
            //将图层添加到地图
            this.MissionMap.Overlays.Add(markers);

            marker.ToolTipText = "我在这里";
            marker.ToolTip.Fill = new SolidBrush(Color.FromArgb(100, Color.Black));
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.TextPadding = new Size(20, 20);


            // 多边形的顶点
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(39.92244, 116.3922));
            points.Add(new PointLatLng(39.92280, 116.4015));
            points.Add(new PointLatLng(39.91378, 116.4019));
            points.Add(new PointLatLng(39.91346, 116.3926));
            GMapPolygon polygon = new GMapPolygon(points, "故宫");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            polygons.Polygons.Add(polygon);
            this.MissionMap.Overlays.Add(polygons);

            this.MissionMap.Overlays.Add(usv_routes);
            //DrawLineBetweenTwoPoint(new PointLatLng(39.923518, 116.539009), new PointLatLng(39.91378, 116.4019));

        }

        int index = 1;
        List<PointLatLng> points1;
        int j = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            double last_lat, last_lng;
            last_lat = cul_lat - 0.003;
            last_lng = cul_lng - 0.005;
            j++;
            points1 = new List<PointLatLng>();

            PointLatLng now_point = new PointLatLng(cul_lat, cul_lng);
            GMapMarker markers_now = new GMarkerGoogle(now_point, GMarkerGoogleType.blue_pushpin);

            usv_routes.Markers.Clear();
            usv_routes.Markers.Add(markers_now);

            cul_lat += 0.003;
            cul_lng += 0.005;

            PointLatLng next_point = new PointLatLng(cul_lat, cul_lng);

            points1.Add(now_point);
            points1.Add(next_point);

            if (index == 1)
            {
                index = 2;
            }
            else
            {
                usv_groute = new GMapRoute(points1, "route001");

                usv_routes.Routes.Add(usv_groute);
            }
        }

        public void simpath()
        {
            PointLatLng curPoint = new PointLatLng(31.938074, 118.789600);

            if (animate_path_on == true)
            {
                this.timer1.Start();
                animate_path_on = false;
            }
            else
            {
                this.timer1.Stop();
                animate_path_on = true;
            }
        }
    }
}
