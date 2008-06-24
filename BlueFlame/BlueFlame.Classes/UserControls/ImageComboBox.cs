using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace BlueFlame.Classes.UserControls
{
    public partial class ImageComboBox : ComboBox
    {

        private ImageList _imageList;
        public ImageList ImageList
        {
            get { return _imageList; }
            set { _imageList = value; }
        }

        public ImageComboBox()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DropDownStyle = ComboBoxStyle.DropDownList;            
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            if (!(Items.Count > 0)) return;
            if (_imageList == null)
            {
                e.Graphics.DrawString(
                    this.Items[e.Index].ToString(),
                    e.Font,
                    new SolidBrush(e.ForeColor),
                    e.Bounds.Left,
                    e.Bounds.Top);
            }
            else
            {
                if (e.Index < 0)
                    e.Graphics.DrawString(this.Text,
                        e.Font,
                        new SolidBrush(e.ForeColor),
                        e.Bounds.Left + _imageList.ImageSize.Width,
                        e.Bounds.Top);
                else
                {
                    if (this.Items[e.Index] is ImageComboBoxItem)
                    {
                        ImageComboBoxItem item = (ImageComboBoxItem)this.Items[e.Index];
                        Color forecolor = (item.Color != Color.FromKnownColor(KnownColor.Transparent)) ? item.Color : e.ForeColor;
                        Font font = item.Bold ? new Font(e.Font, FontStyle.Bold) : e.Font;

                        if (item.ImageIndex != -1)
                        {
                            this._imageList.Draw(
                                e.Graphics,
                                e.Bounds.Left,
                                e.Bounds.Top,
                                item.ImageIndex);

                            e.Graphics.DrawString(
                                item.Text,
                                font,
                                new SolidBrush(forecolor),
                                e.Bounds.Left + 2 +
                               _imageList.ImageSize.Width,
                               e.Bounds.Top);
                        }
                        else if (item.ImageKey != null)
                        {
                            int index = _imageList.Images.IndexOfKey(item.ImageKey);
                            this._imageList.Draw(
                                e.Graphics,
                                e.Bounds.Left,
                                e.Bounds.Top,
                                index);

                            e.Graphics.DrawString(
                                item.Text,
                                font,
                                new SolidBrush(forecolor),
                                e.Bounds.Left + 2 +
                               _imageList.ImageSize.Width,
                               e.Bounds.Top);
                        }
                        else
                        {
                            e.Graphics.DrawString(item.Text, font,
                                new SolidBrush(forecolor), e.Bounds.Left +
                                _imageList.ImageSize.Width, e.Bounds.Top);
                        }
                    }
                    else
                    {
                        e.Graphics.DrawString(this.Items[e.Index].ToString(),
                        e.Font,
                        new SolidBrush(e.ForeColor),
                        e.Bounds.Left,
                        e.Bounds.Top);
                    }
                }
            }

            base.OnDrawItem(e);
        }

    }
}
