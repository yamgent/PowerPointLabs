﻿using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;

namespace PowerPointLabs.ActionFramework.Label
{
    [ExportLabelRibbonId("EffectsLabBlurSelectedGallery")]
    class EffectsLabBlurSelectedLabelHandler : LabelHandler
    {
        protected override string GetLabel(string ribbonId)
        {
            return TextCollection.EffectsLabBlurSelectedGalleryLabel;
        }
    }
}
