﻿// Copyright 2013-2020 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   https://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.

using ImageMagick;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magick.NET.Tests
{
    public partial class MagickImageTests
    {
        [TestClass]
        public class TheSharpenMethod
        {
            [TestMethod]
            public void ShouldUseCorrectRadiusAndSigmaDefaults()
            {
                using (var first = new MagickImage(Files.MagickNETIconPNG))
                {
                    using (var second = first.Clone())
                    {
                        first.Sharpen();
                        second.Sharpen(0, 1.0);

                        var difference = first.Compare(second, ErrorMetric.RootMeanSquared);
                        Assert.AreEqual(first.Signature, second.Signature);
                    }
                }
            }

            [TestMethod]
            public void ShouldUseCompositeAsDefaultChannels()
            {
                using (var first = new MagickImage(Files.MagickNETIconPNG))
                {
                    using (var second = first.Clone())
                    {
                        first.Sharpen(Channels.Composite);
                        second.Sharpen(0, 1.0);

                        var difference = first.Compare(second, ErrorMetric.RootMeanSquared);
                        Assert.AreEqual(first.Signature, second.Signature);
                    }
                }
            }

            [TestMethod]
            public void ShouldSharpenTheImage()
            {
                using (var image = new MagickImage(Files.NoisePNG))
                {
                    using (var original = image.Clone())
                    {
                        image.Sharpen(10, 20);
                        image.Clamp();

                        Assert.AreEqual(0.06675, image.Compare(original, ErrorMetric.RootMeanSquared), 0.00001);
                    }
                }
            }
        }
    }
}