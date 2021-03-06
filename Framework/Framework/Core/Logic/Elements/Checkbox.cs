﻿using OpenQA.Selenium;

namespace Framework.Core.Logic.Elements
{
    class Checkbox : Element
    {
        public string ID { get; set; }
        public string Text { get; set; }
        public bool Visible { get; set; }
        public bool Selected { get; set; }
    }
}
