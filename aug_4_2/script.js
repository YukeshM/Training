let userDetails = [];

const addDetails = (ev) => {
    ev.preventDefault();
    let userDetail = {
        firstName: document.getElementById("firstName").value,
        lastName: document.getElementById("lastName").value,
        mobileNumber: document.getElementById("mobileNumber").value,
        email: document.getElementById("inputEmail").value,
        password: document.getElementById("inputPassword").value,
    };
    userDetails.push(userDetail);
    document.querySelector("form").reset();

    //for displaying details
    console.warn("added", { userDetails });
    let pre = document.querySelector("#msg pre");
    pre.textContent = "\n" + JSON.stringify(userDetails, "\t", 2);

    //saving to localstorage
    localStorage.setItem("MyUserDetails", JSON.stringify(userDetails));
};

document.addEventListener("DOMContentLoaded", () => {
    document
        .getElementById("btn")
        .addEventListener("click", addDetails);
});
