﻿//
// ImageInfo.cs
//
// Author:
//       Roman M. Yagodin <roman.yagodin@gmail.com>
//
// Copyright (c) 2014 
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Drawing;
using System.Net;

namespace R7.ImageHandler
{
	public class ImageInfo
	{
		public Image Image { get; private set; }

		public byte[] ImageByteBuffer { get; private set; }

		public HttpStatusCode? HttpStatusCode { get; private set; }

		public ImageInfo (HttpStatusCode statusCode)
		{
			HttpStatusCode = statusCode;
		}

		public ImageInfo (Image image)
		{
			if (image == null)
			{
				throw new ArgumentNullException ("Image cannot be null");
			}

			Image = image;
		}

		public ImageInfo (byte[] imageBuffer)
		{
			if (imageBuffer == null)
			{
				throw new ArgumentNullException ("ImageBuffer cannot be null");
			}

			ImageByteBuffer = imageBuffer;
		}
	}
}
