using System;
using System.Text;
using System.Drawing;

namespace BlueFlame.Classes.UserControls
{
    public class ImageComboBoxItem : object, IEquatable<ImageComboBoxItem>, IEquatable<string>
    {
        private Color _color;
        private string _text;
        private object _tag;
        private int _imageIndex;
        private string _imageKey;
        private bool _bold;

        #region Properties
        /// <summary>
        /// The foreground text color
        /// </summary>
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// The text to display
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        /// <summary>
        /// Additional Data for the item
        /// </summary>
        public object Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }

        /// <summary>
        ///  The index of the image in the image list
        /// </summary>
        public int ImageIndex
        {
            get { return _imageIndex; }
            set 
            {
                _imageKey = null;
                _imageIndex = value; 
            }
        }

        /// <summary>
        /// The image key of the image in the image list
        /// </summary>
        public string ImageKey
        {
            get { return _imageKey; }
            set 
            {
                _imageIndex = -1;
                _imageKey = value; 
            }
        }

        /// <summary>
        /// Gets or sets a value indicating if the text will be displayed in bold letters
        /// </summary>
        public bool Bold
        {
            get { return _bold; }
            set { _bold = value; }
        }
        #endregion

        /// <summary>
        /// Constructor. Creates an empty combo box element.
        /// </summary>
        public ImageComboBoxItem()
        {
            _color = Color.FromKnownColor(KnownColor.Transparent);
            _text = null;
            _tag = null;
            _imageKey = null;
            _imageIndex = -1;
            _bold = false;
        }

        /// <summary>
        /// Constructor. Creates a combobox item without an image.
        /// </summary>
        public ImageComboBoxItem(string text)
        {
            _text = text;
            _color = Color.FromKnownColor(KnownColor.Transparent);
            _tag = null;
            _imageKey = null;
            _imageIndex = -1;
            _bold = false;
        }

        public ImageComboBoxItem(string text, string imagekey)
        {
            _text = text;
            _color = Color.FromKnownColor(KnownColor.Transparent);
            _tag = null;
            _imageKey = imagekey;
            _imageIndex = -1;
            _bold = false;
        }

        /// <summary>
        /// Constructor. Creates a combo box item with a text and an index for the image to display.
        /// </summary>
        public ImageComboBoxItem(string text, int imageindex)
        {
            _text = text;
            _color = Color.FromKnownColor(KnownColor.Transparent);
            _tag = null;
            _imageKey = null;
            _imageIndex = imageindex;
            _bold = false;
        }

        public override string ToString()
        {
            return _text;
        }
            
        #region IEquatable Member
        public bool Equals(string other)
        {
            return (_text == other);
        }
        
        public bool  Equals(ImageComboBoxItem other)
        {
            return (_text == other._text);
        }
        #endregion
    }
}
