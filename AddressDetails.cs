using System;
namespace AddressDetails
{
    class Address
    {
        private int houseNo;
        private string houseName;
        private int pinCode;

        public Address(int houseNo, string houseName, int pinCode)
        {
            this.houseNo = houseNo;
            this.houseName = houseName;
            this.pinCode = pinCode;
        }
        public int GetHouseNo()
        {
            return houseNo;
        }
        public string GetHouseName()
        {
            return houseName;
        }
        public int GetPinCode()
        {
            return pinCode;
        }
    }
}
