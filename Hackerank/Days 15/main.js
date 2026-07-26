process.stdin.resume();
process.stdin.setEncoding('ascii');

var input_stdin = "";
var input_stdin_array = "";
var input_currentline = 0;

process.stdin.on('data', function (data) {
    input_stdin += data;
});

process.stdin.on('end', function () {
    input_stdin_array = input_stdin.split("\n");
    main();    
});

function readLine() {
    return input_stdin_array[input_currentline++];
}

function Node(data){
    this.data = data;
    this.next = null;
}

function Solution(){

    this.insert = function(head, data){
        var newNode = new Node(data);

        if(head == null){
            return newNode;
        }

        var current = head;

        while(current.next != null){
            current = current.next;
        }

        current.next = newNode;

        return head;
    };

    this.display = function(head){
        var current = head;

        while(current != null){
            process.stdout.write(current.data + " ");
            current = current.next;
        }
    };
}

function main(){
    var myList = new Solution();

    var T = parseInt(readLine());

    var head = null;

    for(var i = 0; i < T; i++){
        var data = parseInt(readLine());
        head = myList.insert(head, data);
    }

    myList.display(head);
}