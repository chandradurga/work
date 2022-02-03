const electron =require('electron');
const url =require('url');
const path =require('path');

const {app,BrowserWindow,Menu}=electron;
let mainWindow;
let addWindow;
//listen for the app to beready
app.on('ready',function()
{
// create new window
mainWindow =new BrowserWindow({});
//load htm into windoe
mainWindow.loadURL(url.format({
    pathname:path.join(__dirname,'mainWindow.html'),
    protocol:'file:',
    slashes:true
})); 
mainWindow.on('closed',function(){
    app.quit();
});
//Build menu from template
const mainMenu=Menu.buildFromTemplate(mainMenuTemplate);
//insert menu
Menu.setApplicationMenu(mainMenu);
});
//Handle create add window
function createAddWindow()
{
    // create new window
addWindow =new BrowserWindow({
    width:300,
    height:200,
    title:'Add shpping list item'
});
//load htm into windoe
addWindow.loadURL(url.format({
    pathname:path.join(__dirname,'addWindow.html'),
    protocol:'file:',
    slashes:true
})); 
//garbage collection handle
addWindow.on('close',function(){
    addWindow=null;
});
}
// create menu template
const mainMenuTemplate =[
    {
        label:'File',
        submenu:[
            {
                label:'add Item',
                click(){
                 createAddWindow();

                }
            },
            {
                label:'clear Items'
            },
            {
                label:'Note pad',
                click()
                {
                    var child =require('child_process').execFile;
                    var executablepath="C:\\Windows\\system32\\notepad.exe";
                    child(executablepath,function(err,data){
                     if(err){
                         console.error(err);
                         return;
                     }
                     console.log(data.toString());
                    });
                }
            },
             {
                label:'clear Items'
            },
            {
                label:'word pad',
                click()
                {
                    var child =require('child_process').execFile;
                    var executablepath="C:\\Program Files\\Windows NT\\Accessories\\wordpad.exe";
                    child(executablepath,function(err,data){
                     if(err){
                         console.error(err);
                         return;
                     }
                     console.log(data.toString());
                    });
                }
            },
             {
                label:'clear Items'
            },
            {
                label:'Paint',
                click()
                {
                    var child =require('child_process').execFile;
                    var executablepath="C:\\Windows\\system32\\mspaint.exe";
                    child(executablepath,function(err,data){
                     if(err){
                         console.error(err);
                         return;
                     }
                     console.log(data.toString());
                    });
                }
            },
            {
                label:'Quit',
                accelerator: process.platform == 'darwin' ? 'Command+Q' :
                'Ctrl+Q',
                click(){
                    app.quit();
                }
            }
        ]
    }
];
//if mac, add emty obejct to menu
if(process.platform == 'darwin')
{
    mainMenuTemplate.unshift({});

}
// add develpoer tool item if not in production
if(process.env.NODE_ENV !='production'){
    mainMenuTemplate.push(
        {
            label:'Developer tools',
            submenu:[
                {
                    label:'Toggle dev tools',
                    accelerator: process.platform == 'darwin' ? 'Command+I' :
                    'Ctrl+I',
                    click(item,focusedWindow)
                    {
                        focusedWindow.toggleDevTools();
                    }
                },
                {
                    role:'reload'
                }
            ]
        }
    );
}