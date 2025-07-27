import React from 'react';
import Cart from './Cart';

class OnlineShopping extends React.Component {
  render() {
    const items = [
      { itemname: 'Laptop', price: 80000 },
      { itemname: 'TV', price: 120000 },
      { itemname: 'Washing Machine', price: 50000 },
      { itemname: 'Mobile', price: 30000 },
      { itemname: 'Fridge', price: 70000 },
    ];

    return (
      <div style={{ textAlign: 'center' }}>
        <h1 style={{ color: 'green' }}>Items Ordered :</h1>
        <table align="center" border="1">
          <thead>
            <tr>
              <th>Name</th>
              <th>Price</th>
            </tr>
          </thead>
          <tbody>
            {items.map((item, index) => (
              <Cart key={index} itemname={item.itemname} price={item.price} />
            ))}
          </tbody>
        </table>
      </div>
    );
  }
}

export default OnlineShopping;
