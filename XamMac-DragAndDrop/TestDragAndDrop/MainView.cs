﻿using System;
using MonoMac.AppKit;
using MonoMac.Foundation;

namespace TestDragAndDrop
{
	[Register("MainView")]
	public class MainView : NSView
	{
		public MainView(IntPtr handle):base(handle)
		{

		}

		#region - uncomment the below to handle drag and drops in the entire window
		public override void AwakeFromNib()
		{
			base.AwakeFromNib();
			RegisterForDraggedTypes(new string[]{"NSFilenamesPboardType"});
		}
			

		public override NSDragOperation DraggingEntered(NSDraggingInfo sender)
		{
			NSPasteboard draggingPasteBoard = sender.DraggingPasteboard;
			Console.WriteLine("Entered Sender: {0}", draggingPasteBoard.PasteboardItems[0].GetStringForType("public.file-url"));
			return NSDragOperation.Copy;
		}

		public override bool PerformDragOperation(NSDraggingInfo sender)
		{
			NSPasteboard draggingPasteBoard = sender.DraggingPasteboard;
			Console.WriteLine("Perform Sender: {0}", draggingPasteBoard.PasteboardItems[0].GetStringForType("public.file-url"));
			return true;
		}
		#endregion
	}
}

