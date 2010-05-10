﻿/* **********************************************************************************
 *
 * Copyright (c) Tanzim Saqib. All rights reserved.
 *
 * This source code is subject to terms and conditions of the Microsoft Public
 * License (Ms-PL). A copy of the license can be found in the license.htm file
 * included in this distribution.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * For continued development:   http://www.TanzimSaqib.com
 * Source:                      http://cassini.googlecode.com/
 * License information:         http://www.opensource.org/licenses/ms-pl.html
 *
 * **********************************************************************************/

namespace Cassini.Configuration
{
    using System.Xml.Serialization;

    [XmlRoot(CassiniConfigConstants.ROOT_ELEMENT_NAME)]
    public class CassiniConfig 
    {
        [XmlElement(CassiniConfigConstants.WEBSITES)]
        public CassiniWebsitesConfig Websites = new CassiniWebsitesConfig();

        [XmlElement(CassiniConfigConstants.IS_RUNNING)]
        public bool IsRunning { get; set; }
    }
}
