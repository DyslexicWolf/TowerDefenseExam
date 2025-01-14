using System;
using System.Collections;
using System.ComponentModel;
using TowerDefense.Model;
using UnityEngine;

namespace TowerDefense.Presenter
{
    public class RoadblockPresenter : PresenterBase<RoadblockModel>
    {
        protected override void Destroy_Self(object sender, EventArgs e)
        {
            Destroy(gameObject);
        }

        protected override void Property_Changed(object sender, PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
            //if (e.PropertyName == nameof(TowerModel.ShotsFired))
            //{
            //    StartCoroutine(ShootAnimation());
            //}
        }
    }
}

