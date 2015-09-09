﻿using System;
using System.Collections;
using System.Linq;
using BizTalkComponents.Utils;

namespace BizTalkComponents.PipelineComponents.EncryptMessage
{
    public partial class EncryptMessage
    {
        public string Name { get { return "EncryptMessage"; } }
        public string Version { get { return "1.0"; } }
        public string Description
        {
            get
            {
                return
                    "Encrypts the message using AES encryption.";
            }
        }

        public void GetClassID(out Guid classID)
        {
            classID = Guid.Parse("0BF79C72-008A-46FF-955B-EAFBA0F78E9E");
        }

        public void InitNew()
        {
        }

        public IEnumerator Validate(object projectSystem)
        {
            return ValidationHelper.Validate(this, false).ToArray().GetEnumerator();
        }

        public bool Validate(out string errorMessage)
        {
            var errors = ValidationHelper.Validate(this, true).ToArray();

            if (errors.Any())
            {
                errorMessage = string.Join(",", errors);

                return false;
            }

            errorMessage = string.Empty;

            return true;
        }

        public IntPtr Icon { get { return IntPtr.Zero; } }
    }
}