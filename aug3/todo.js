const todo = [];
document.querySelector("#push").onclick = function () {
    if (document.querySelector("#newtask input").value.length == 0) {
        alert("please enter a to do list");
    } else {
      todo.push({ todolist: 'value' })
      console.log(todo)
      localStorage.setItem('mytodolist',JSON.stringify(todo))
        document.querySelector("#tasks").innerHTML += `
    <div class = "task">
    <span id="taskname">
    ${document.querySelector("#newtask input").value}
    </span>
    <button class = "delete">
    Delete
    </button>
    </div >
    `;
        var current_tasks = document.querySelectorAll(".delete");
        for (let i = 0; i < current_tasks.length; i++) {
            current_tasks[i].onclick = function () {
              this.parentNode.remove();
              localStorage.removeItem('mytodolist')
              const info = localStorage.get('mytodo')
              localStorage.clear()
            };
        }
        var tasks = document.querySelectorAll(".task");
        for (let i = 0; i < tasks.length; i++) {
            tasks[i].onclick = function () {
                this.classList.toggle("completed");
            };
        }

        document.querySelector("#newtask input").value = "";
    }
};
