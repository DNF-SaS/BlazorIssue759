// <copyright file="Program.cs" company="DotNetFabrik">
//     Copyright (c) DotNetFabrik － All rights reserved.
// </copyright>

namespace WebApplication12
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using Microsoft.AspNetCore.Blazor.Components;
	using Microsoft.AspNetCore.Blazor.RenderTree;

	public class ComponentBase : BlazorComponent
	{
		private string prefix;
		private bool debugLog = true;
		 
		public ComponentBase()
		{
			this.prefix = $"BASE({this.GetType().Name}) ENTER";
		}

		protected override void BuildRenderTree(RenderTreeBuilder builder)
		{
			base.BuildRenderTree(builder);
		}

		protected new void StateHasChanged()
		{
			Program.Log(this.prefix);
			base.StateHasChanged();
		}

		protected override void OnInit()
		{
			if ( this.debugLog )
				Program.Log(this.prefix);

			base.OnInit();
		}

		protected override void OnAfterRender()
		{
			if ( this.debugLog )
				Program.Log(this.prefix);

			base.OnAfterRender();
		}

		protected override Task OnAfterRenderAsync()
		{
			if ( this.debugLog )
				Program.Log(this.prefix);

			return base.OnAfterRenderAsync() ?? Task.CompletedTask;
		}

		protected override Task OnInitAsync()
		{
			if ( this.debugLog )
				Program.Log(this.prefix);

			return base.OnInitAsync() ?? Task.CompletedTask;
		}

		protected override void OnParametersSet()
		{
			if ( this.debugLog )
				Program.Log(this.prefix);

			base.OnParametersSet();
		}

		protected override Task OnParametersSetAsync()
		{
			if ( this.debugLog )
				Program.Log(this.prefix);

			return base.OnParametersSetAsync() ?? Task.CompletedTask;
		}

		public override void SetParameters(ParameterCollection parameters)
		{
			if ( this.debugLog )
				Program.Log(this.prefix);

			base.SetParameters(parameters);
		}

		protected override bool ShouldRender()
		{
			if ( this.debugLog )
				Program.Log(this.prefix);

			return base.ShouldRender();
		}
	}
}
