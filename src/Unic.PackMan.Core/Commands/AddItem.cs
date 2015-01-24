﻿namespace Unic.PackMan.Core.Commands
{
    using System.Linq;
    using Pipelines.AddItem;
    using Sitecore.Diagnostics;
    using Sitecore.Pipelines;
    using Sitecore.Shell.Framework.Commands;

    public class AddItem : Command
    {
        public override void Execute(CommandContext context)
        {
            var item = context.Items.FirstOrDefault();
            Assert.IsNotNull(item, "Item must not be null");
            
            var pipelineArgs = new AddItemPipelineArgs { Item = item, AddWithSubItems = false };
            CorePipeline.Run("PackMan.AddItem", pipelineArgs);
        }
    }
}
