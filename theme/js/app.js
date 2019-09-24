const name = document.getElementById('Name')
const subject = document.getElementById('Subject')
const email = document.getElementById('Email')
const message = document.getElementById('Message')
const form = document.getElementById('myForm')
const error_message = document.getElementById('error_message')
form.addEventListener('submit', (e) => {
    let messages = []
    if (name.value === '' || name.value == null) {
        messages.push('Adınızı giriniz!')
    }
    if (messages.length > 0) {
        e.preventDefault()
        error_message.innerText = messages.join(', ')
    }
})