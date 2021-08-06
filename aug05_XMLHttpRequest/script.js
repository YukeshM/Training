window.onload = () => {
    var xhr = new XMLHttpRequest();
    xhr.onreadystatechange =function ()
     {
        if(this.readyState == 4 && this.status == 200)
        {
            var info = JSON.parse(xhr.responseText)
            var postData = document.querySelector('#tBody')

            info.data.map((details) =>{
                postData.innerHTML += 
                `<tr>
                <td>${details.id}</td>
                <td>${details.email}</td>
                <td>${details.first_name}</td>
                <td>${details.last_name}</td>
                <td><img src='${details.avatar}'</td>
                </tr>`
            })
        }
    }
    xhr.open('GET', 'https://reqres.in/api/users?page=2')
xhr.send()
}


