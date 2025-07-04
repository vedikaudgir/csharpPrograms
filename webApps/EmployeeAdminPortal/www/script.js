const apiBaseUrl = 'const apiBaseUrl = https://localhost:7205/api/EmployeeController';

    window.onload = () => {
        fetch(apiBaseUrl)
            .then(res => res.json())
            .then(employees => {
                const list = document.getElementById('employeeList');
                list.innerHTML = '';
                employees.forEach(emp => {
                    const li = document.createElement('li');
                    li.textContent = `${emp.name} - ${emp.position}`;
                    list.appendChild(li);
                });
            })
            .catch(err => console.error('Error fetching employees:', err));
    };

document.getElementById('employeeForm').addEventListener('submit', function (e) {
    e.preventDefault();
    const name = document.getElementById('name').value;
    const position = document.getElementById('position').value;

    fetch(apiBaseUrl, {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ name, position })
    })
        .then(res => res.json())
        .then(() => {
            alert('Employee added!');
            window.location.reload(); // refresh list
        })
        .catch(err => console.error('Error adding employee:', err));
});


window.onload = () => {
    fetch(apiBaseUrl)
        .then(res => res.json())
        .then(employees => {
            const list = document.getElementById('employeeList');
            list.innerHTML = '';
            employees.forEach(emp => {
                const li = document.createElement('li');
                li.textContent = `${emp.name} - ${emp.position}`;
                list.appendChild(li);
            });
        })
        .catch(err => console.error('Error fetching employees:', err));
};


document.getElementById('employeeForm').addEventListener('submit', function (e) {
    e.preventDefault();
    const name = document.getElementById('name').value;
    const position = document.getElementById('position').value;

    fetch(apiBaseUrl, {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ name, position })
    })
        .then(res => res.json())
        .then(() => {
            alert('Employee added!');
            window.location.reload(); // refresh list
        })
        .catch(err => console.error('Error adding employee:', err));
});
