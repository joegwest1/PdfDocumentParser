//********************************************************************************************
//Author: Sergey Stoyan
//        sergey.stoyan@gmail.com
//        http://www.cliversoft.com
//********************************************************************************************
using System;

namespace Cliver.PdfDocumentParser
{
    /// <summary>
    /// parsing rules corresponding to certain pdf document layout
    /// </summary>
    public partial class Template
    {
        //public IEnumerable<Field> GetFieldDefinitions(string fieldName)
        //{
        //    return Fields.Where(x => x.Name == fieldName);
        //}

        public class Field
        {
            public string Name;

            public RectangleF Rectangle;
            /// <summary>
            /// when set, Left shifts as the anchor shifts
            /// </summary>
            public SideAnchor LeftAnchor;
            /// <summary>
            /// when set, Top shifts as the anchor shifts
            /// </summary>
            public SideAnchor TopAnchor;
            /// <summary>
            /// when set, Right shifts as the anchor shifts
            /// </summary>
            public SideAnchor RightAnchor;
            /// <summary>
            /// when set, Bottom shifts as the anchor shifts
            /// </summary>
            public SideAnchor BottomAnchor;
            public class SideAnchor
            {
                public int Id;
                public float Shift;// { get { return 0; } set { } }
            }

            public Field()
            {
            }

            public ValueTypes DefaultValueType = ValueTypes.PdfText;

            public enum ValueTypes
            {
                PdfText,
                PdfTextLines,
                PdfCharBoxs,
                OcrText,
                OcrTextLines,
                OcrCharBoxs,
                Image,
            }

            public bool IsSet()
            {
                return Rectangle != null && Rectangle.Width > 0 && Rectangle.Height > 0;
            }

            /// <summary>
            /// set by the custom application. When set, the field is considered as a table column intercepted with the field specified by ColumnOf. 
            /// In this way, all the fields which are columns of the same field always contain the same number of lines. 
            /// Not all field types supported!
            /// </summary>
            public string ColumnOfTable = null;
        }
    }
}