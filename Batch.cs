// Chris Lund Schober
using System;

namespace Business_under_control
{
    /*
     * Batch - Contains program data about the Batch
     */
    class Batch
    {
        private long ID;
        private DateTime buyDate;
        private DateTime expirationDate;
        private int originalCuantity;
        private int remainingCuantity;
        private Product product;
    }
}
