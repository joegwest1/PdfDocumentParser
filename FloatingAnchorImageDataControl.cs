﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliver.PdfDocumentParser
{
    public partial class FloatingAnchorImageDataControl : UserControl
    {
        public FloatingAnchorImageDataControl(DataGridViewRow row)
        {
            InitializeComponent();

            Row = row;
        }
        public readonly DataGridViewRow Row;

        public Template.FloatingAnchor.ImageDataValue Value
        {
            get
            {
                _value.FindBestImageMatch = findBestImageMatch.Checked;
                _value.BrightnessTolerance = (float)brightnessTolerance.Value;
                _value.DifferentPixelNumberTolerance = (float)differentPixelNumberTolerance.Value;
                return _value;
            }
            set
            {
                _value = value;
                findBestImageMatch.Checked = value.FindBestImageMatch;
                brightnessTolerance.Value = (decimal)value.BrightnessTolerance;
                differentPixelNumberTolerance.Value = (decimal)value.DifferentPixelNumberTolerance;
                if (value.ImageBoxs != null && value.ImageBoxs.Count > 0)
                    picture.Image = value.ImageBoxs[0].ImageData.GetImage();
            }
        }
        Template.FloatingAnchor.ImageDataValue _value;

        public bool FindBestImageMatch
        {
            get
            {
                return findBestImageMatch.Checked;
            }
            //set
            //{
            //    findBestImageMatch.Checked = value;
            //}
        }

        public float BrightnessTolerance
        {
            get
            {
                return (float)brightnessTolerance.Value;
            }
            //set
            //{
            //    brightnessTolerance.Value = (decimal)value;
            //}
        }

        public float DifferentPixelNumberTolerance
        {
            get
            {
                return (float)differentPixelNumberTolerance.Value;
            }
            //set
            //{
            //    differentPixelNumberTolerance.Value = (decimal)value;
            //}
        }

        //public Image Image
        //{
        //    get
        //    {
        //        return picture.Image;
        //    }
        //    //set
        //    //{
        //    //    picture.Image = value;
        //    //}
        //}
    }
}
