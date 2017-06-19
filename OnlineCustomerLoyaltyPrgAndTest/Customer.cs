using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCustomerLoyaltyPrgAndTestNS
{
    public class Customer
    {
        public Guid Id { get; private set; }

        public Customer()
        {
            Id = Guid.NewGuid();
        }

        int points;

        public int getMyPointsForPurchase(ProductVendor vendor, int productId, int qty)
        {
            points = vendor.requirePoints(this, productId, qty);
            return points;
        }

        // TODO ELEV opret metoden getMyPointsForPurchase(vendor, productId, qty)
        // TODO ELEV Implementer en måde at huske om vi har købt samme vare hos samme leverandør før, f.eks. med Dictionary<ProductVendor, int>

    }
}
