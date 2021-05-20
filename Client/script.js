const urlRes ='https://localhost:5001/api/Login/Login/kukish'

const sendData = async(url,data) =>{
    const response = await fetch(url,
        {
            method:'POST',
            'content-type': 'text/json',
            body: {
                "id": 1,
                "email": "wands180@gmail.com",
                "password": "12345"
            },
        } );
       /* if (!response.ok ){
            throw new Error('Ошибка по адресу ${url}, статус ошибки ${response}');
        }
*/
        return await response.json()
}


const sendInfromation = () =>{

       

       const cartForm =document.getElementById('card');

       cartForm.addEventListener('submit', e => {
           e.preventDefault();
           const formData = new FormData (cartForm)

           sendData('https://localhost:5001/api/Login/Login/kukish', formData);
       });
}


sendInfromation();




var myHeaders = new Headers();
myHeaders.append("Content-Type", "application/json");

var raw = JSON.stringify({
  "id": 0,
  "email": "string",
  "password": "string"
});

var requestOptions = {
  method: 'POST',
  headers: myHeaders,
  body: raw,
  redirect: 'follow'
};

fetch("https://localhost:5001/api/Login/Login/AndreyTop", requestOptions)
  .then(response => response.text())
  .then(result => console.log(result))
  .catch(error => console.log('error', error));

