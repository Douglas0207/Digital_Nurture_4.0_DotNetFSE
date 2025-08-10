// EmployeesList.js
import React from 'react';
import EmployeeCard from './EmployeeCard';

function EmployeesList() {
  const employees = [
    { id: 1, name: 'John', role: 'Developer' },
    { id: 2, name: 'Alice', role: 'Designer' },
    { id: 3, name: 'Bob', role: 'Manager' },
  ];

  return (
    <div>
      <h2>Employee List</h2>
      {employees.map(emp => (
        <EmployeeCard key={emp.id} employee={emp} />
      ))}
    </div>
  );
}

export default EmployeesList;
