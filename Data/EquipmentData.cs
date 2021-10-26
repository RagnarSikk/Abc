﻿using Abc.Data.Abstract;

namespace Abc.Data {
    public class EquipmentData : NamedItemData {
        //public string Name { get; set; }
        public string Description { get; set; }
        public int AmountAvailable { get; set; }
        public int AmountInUsing { get; set; }

        // võiks teha nii, et näeb mitu on kasutusel ja mitu on saadaval

        // TODO: mõelda mis propertyd veel võiksid olla
    }
}
