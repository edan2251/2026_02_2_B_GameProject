let express = require('express')                        //express 모듈을 가져온다.
let app = express();                                    //express 를 app 이름으로 정의하고 사용한다.

app.get('/' , function(req, res){     //기존 라우터에서 Hello world 를 반환한다.
    res.send ('hello world');
});

app.get('/about' , function(req, res){     //기존 라우터에서 Hello world 를 반환한다.
    res.send ('Player Data 0010101010');
});

app.listen(3000, function(){
    console.log('listening on port 3000');
})