﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestApi.Repository.Models;

namespace TestApi.Repository.Fake {
    public class FakeData {
        private List<APart> data;
        public IList<APart> GetData() {
            data = new List<APart>();
            data.Add(new APart() {
                id = 1,
                name = "SACHS 34542",
                orig_article = "Nissan 54303-BN425",
                description = "Серия амортизаторов SUPER TOURING",
                full_description = "Амортизаторы на любой вкус и по сходной цене отвечают высоким требованиям комфорта и безопасности – почти для любого автомобиля. Максимальная надежность амортизаторов Super Touring устанавливает стандарт для этой отрасли. Разработанные и созданные со всей компетенцией завода-изготовителя они представляют собой безопасность, надежность и стабильность.",
                applicability = "Nissan Almera N16, Nissan Primera P12",
                price = "4354 руб.",
                url_img = "img/1.jpg"
            });
            data.Add(new APart() {
                id = 2,
                name = "Nissan 54320-95F0A",
                orig_article = "Nissan 54320-95F0A",
                description = "Оригинальная опора.",
                full_description = "Оригинальная опора Nissan. Качество 100%",
                applicability = "Nissan Almera N16, Nissan Primera P12",
                price = "1350 руб.",
                url_img = "img/2.jpg"
            });
            data.Add(new APart() {
                id = 3,
                name = " Bridgestone Turanza T001",
                orig_article = "T001",
                description = "Премиальная летняя шина.",
                applicability = "195/65 R15 91V",
                price = "3654 руб.",
                url_img = "img/3.jpg"
            });
            data.Add(new APart() {
                id = 4,
                name = "Hyundai 28113-1R100",
                orig_article = "Hyundai 28113-1R100",
                description = "Фильтр воздушный.",
                applicability = "Hyundai Solaris",
                price = "200 руб.",
                url_img = "img/4.jpg"
            });

            return data;
        }
    }
}