﻿using System.Windows.Forms;

namespace UELib.Core
{
	public partial class UField
	{
		protected override void InitNodes( TreeNode node )
		{
			ParentNode = AddSectionNode( node, typeof(UField).Name );
			AddTextNode( ParentNode, "SuperField:" + (Super != null ? Super.Name : "None") + "(" + _SuperIndex + ")" ); 
			AddTextNode( ParentNode, "NextField:" + (NextField != null ? NextField.Name : "None") + "(" + _NextIndex + ")" ); 
			base.InitNodes( ParentNode );
		}
	}
}
