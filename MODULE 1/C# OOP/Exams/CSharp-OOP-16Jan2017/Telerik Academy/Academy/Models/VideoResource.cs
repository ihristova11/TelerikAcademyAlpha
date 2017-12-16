﻿using System;
using Academy.Models.Contracts;
using Academy.Models.Utilities;

namespace Academy.Models
{
    public class VideoResource : ILectureResource
    {
        private string name;
        private string url;

        public string Name {
            get { return this.name; }
            set
            {
                Validator.CorrectName(value, Constants.MinResourceName, Constants.MaxResourceName, Constants.InvalidResourceName);

                this.name = value;
            }
        }
        public string Url {
            get { return this.url; }
            set
            {
                Validator.CorrectName(value, Constants.MinUrl, Constants.MaxUrl, Constants.InvalidResourceURL);

                this.url = value;
            }
        }
    }
}
