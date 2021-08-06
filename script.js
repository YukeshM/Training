window.onload = () => {
    var xhr = new XMLHttpRequest();
    xhr.onreadystatechange = () => {
        if(this.readyState == 4 && this.status == 200){
            var info = JSON.parse(this.responseText)
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




// const getBtn = document.getElementById('getButton')
// const postBtn = document.getElementById('postButton')

// const sendHttpRequest = (method, url) => {
//     const promise = new Promise((resolve, reject) => {
//         const xhr = new XMLHttpRequest();
//         xhr.open(method, url);

//     xhr.responseType = 'json';

//     xhr.onload = () => {
//         resolve(xhr.response);
//     };
//     xhr.send();
// });
// return promise;
// };

// const getData = () => {
//     sendHttpRequest('GET', '').then(responseData =>{
//         console.log(responseData);
//     });
// };

// const postData = () => {
//     array.forEach(element => {
        
//     });
// };

// getBtn.addEventListener('click',getData)
// postBtn.addEventListener('click',postData)