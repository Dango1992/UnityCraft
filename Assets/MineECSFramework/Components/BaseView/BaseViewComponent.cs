using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dango.MineECSFramework
{
    public class BaseViewComponent : BaseComponent, IViewComponent
    {
        public int ViewId { get; }

    }
}
