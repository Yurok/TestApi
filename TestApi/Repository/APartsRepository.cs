using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestApi.Repository.Fake;
using TestApi.Repository.Models;

namespace TestApi.Repository {
    public class APartsRepository {
        private IList<APart> data;

        public APartsRepository() {
            var fakeData = new FakeData();
            data = fakeData.GetData();
        }

        public IList<APart> Get () {
            return data;
        }

        public APart Get(int id) {
            return data.FirstOrDefault(x=>x.id == id);
        }
    }
}