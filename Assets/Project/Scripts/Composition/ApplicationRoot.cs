using UnityEngine;
using BmiApp.Domain.BmiCalculater.Repository;
using BmiApp.Domain.BmiCalculater.Eintities;
using BmiApp.Infrastructure.BmiCalculator;

namespace BmiApp.Composition {

    public class ApplicationRoot : MonoBehaviour {

        private void Start() {

            var dataStore = new TemporaryHistoryDataStore() as IHistoryDataStore;



        }

    }

}