using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace LeagueAutologin.Extension
{
    public class AccList : ScrollableControl
    {

        public List<AccListItem> Items;
        private Font accFont, rankFont, regionFont;

        // Consts
        private const int ITEM_WIDTH = 240;
        private const int ITEM_HEIGHT = 54;

        public int MaximumHeight { get; set; } = ITEM_HEIGHT * 4;

        public AccList()
        {
            Items = new List<AccListItem>();
            accFont = new Font("Segoe UI Semibold", 13f);
            rankFont = new Font("Segoe UI", 10f);
            regionFont = new Font("Segoe UI", 8f);
            Size = new Size(ITEM_WIDTH, MaximumHeight);

            this.SetStyle(
           ControlStyles.AllPaintingInWmPaint |
           ControlStyles.UserPaint |
           ControlStyles.DoubleBuffer,
           true);

            this.ResizeRedraw = true;
            this.HorizontalScroll.Maximum = 0;
            this.VerticalScroll.SmallChange = 1;
            this.VerticalScroll.LargeChange = 1;

        }

        public void Clear()
        {
            Items.Clear();
        }

        public void Add(AccListItem item)
        {
            if (Size.Width != ITEM_WIDTH) Size = new Size(ITEM_WIDTH, 0);

            // Max visible size
            Size = new Size(Size.Width, MaximumHeight);

            // Full size
            this.AutoScrollMinSize = new Size(Size.Width, (Items.Count + 1) * ITEM_HEIGHT);
            Items.Add(item);
        }

        /*
         *   Size = new System.Drawing.Size(280, 54);
            accFont = new Font("Segoe UI Semibold", 13f);
            rankFont = new Font("Segoe UI", 10f);
            regionFont = new Font("Segoe UI", 8f);
          */
        protected override void OnPaint(PaintEventArgs e)
        {
            // Clear
            e.Graphics.Clear(Color.FromArgb(249, 249, 249));

            e.Graphics.TranslateTransform(this.AutoScrollPosition.X,
                                 this.AutoScrollPosition.Y);

            for (int i = 0; i < Items.Count; i++)
            {
                AccListItem item = Items[i];

                if (hoveredItem == i)
                    e.Graphics.FillRectangle(Brushes.LightGray, 0, i * ITEM_HEIGHT, ITEM_WIDTH, ITEM_HEIGHT);

                // Border          
                e.Graphics.DrawLine(Pens.LightGray, 0, (i + 1) * ITEM_HEIGHT - 1, Width, (i + 1) * ITEM_HEIGHT - 1);

                // Draw Icon (35,40)
                // 10, 5, 35, 40
                if (item.RankImage != null)
                    e.Graphics.DrawImage(item.RankImage, 10, i * ITEM_HEIGHT + 8, 35, 40);

                // Draw account name
                e.Graphics.DrawString(item.Nickname, accFont, Brushes.Black, 52, i * ITEM_HEIGHT + 6);

                // Draw rank
                e.Graphics.DrawString(item.RankText, rankFont, Brushes.DimGray, 53, i * ITEM_HEIGHT + 27);

                // Draw region
                SizeF size = e.Graphics.MeasureString(item.Region, regionFont);
                int scrollOffset = this.VerticalScroll.Visible ? 30 : 0;
                e.Graphics.DrawString(item.Region, regionFont, Brushes.DarkGray, ITEM_WIDTH - size.Width - 1 - scrollOffset, (i + 1) * ITEM_HEIGHT - 16);

                // e.Graphics.DrawString(x + " " + y, regionFont, Brushes.Red, 0,0);

            }

            base.OnPaint(e);
        }

        int hoveredItem = -1;
        private int LastHoveredIndex { get; set; } = -1;
        public AccListItem LastHoveredItem {
            get {
                if (LastHoveredIndex == -1) return null;
                return Items[LastHoveredIndex];
            }
        }

        // int x = 0, y = 0;
        protected override void OnMouseMove(MouseEventArgs e)
        {
            // x = e.X;y = e.Y;
            hoveredItem = -1;

            int x = e.X;
            int y = e.Y - this.AutoScrollPosition.Y;

            if (x > 0 && x < ITEM_WIDTH)
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    if (y > i * ITEM_HEIGHT && y < (i + 1) * ITEM_HEIGHT)
                    {
                        hoveredItem = i;
                        LastHoveredIndex = hoveredItem;
                    }
                }
            }

            Refresh();
            base.OnMouseMove(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {

            base.OnMouseClick(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {

            hoveredItem = -1;
            Refresh();

            base.OnMouseLeave(e);
        }
    }
}
