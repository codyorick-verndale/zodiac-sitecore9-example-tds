﻿using Constellation.Foundation.ModelMapping;
using Constellation.Foundation.Mvc;
using Website.Areas.ExampleSite.Models.Subcontent;

namespace Website.Areas.ExampleSite.Controllers.Subcontent
{
	public class JumbotronController : Constellation.Foundation.Mvc.Patterns.Controllers.DatasourceRenderingController<JumbotronModel>
	{
		public JumbotronController(IViewPathResolver viewPathResolver, IModelMapper modelMapper) : base(viewPathResolver, modelMapper)
		{
		}
	}
}