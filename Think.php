<?php
user.php upload.php
fileName.php fileName.php
return array(
	"KEY":"VALUE",
);
'LOAD_EXT_CONFIG'       =>  'user,upload',
'LOAD_EXT_CONFIG'       =>  'fileName,fileName',
define('CONF_EXT', '.xml/.other');


1.普通形式路由(get形式路由) http://.../index/?m=Home_&c=controller&a=functionName/v=value  
2.pathinfo路由形式(默认) http://.../index/Home_/controller/functionName/v/value
3.rewrite路由形式 http://.../Home_/controller/functionName/v/value
4.兼容路由形式 http://.../index/?s=/Home_/controller/functionName/v/value

U('URLLocation/fun', array('v'=>'value'));

系统跳转方法(Controller)
$this->success($message,jumpUrl,$ajax);
$this->error($message,jumpUrl,$ajax);

视图展示
$this->display();
获取视图
$this->fetch()；
View 注释 {//注释}
view function
{$var|functionName1|functionName2=agr1,arg2,...}
functionName1表示需要使用的第一个函数
functionName2表示需要使用的第二个函数
arg函数2参数
###表示变量自身
默认值 {$var|default=defaultvaue}

变量分配
$var = $this->assign('var', $phpvar); 
展示数据{$var}	{$arr['key']} {$arr.key} {$obj->att}  {$obj:att}


模板常量替换机制  
自定义模板常量
TMPL_PARSE_STRING' => array('__ADMIN__'=>'PATH')
__MODLE__		从域名后到分组名
__CONTROLLER__	从域名后到控制器
__ACTION__ 		从域名后到方法
__PUBLIC__		站点根目录下的Public
__SELF__ 		从域名后到最后

系统变量
$Think.server
$Think.get
$Think.pot
$Think.request
$Think.cookie
$Think.session
$Think.config

文件包含 <include file='filepath' var='value'/> 展示数据[var]

循环遍历 volist foreach
<volist name='var' id='当前遍历到的元素'></volist>	
<foreach name='var' item='当前遍历到的元素'</foreach>

<if condition='条件表达式'>

	<elseif condition='条件表达式'/>

	<else />

</if>
php标签 <?php?> <php></php>



模型的创建 TableNameModel.class.php
快速实例化 M(模型名) D(不带前缀的表名)
D 自定义模型 如果自定义模型不存在则实例化父类模型
M 实例化父类模型

$model->create();
self::EXISTS_VALIDATE 0 存在字段就验证 默认 
self::MUST_VALIDATE 1   必须验证
self::VALUE_VALIDATE 2  值不为空的时候验证

CURD
$result = $model->add(array('key'=>'value')); $result 主键自增长的id $model->addAll();
$result = $model->save(array('pkeyid'=>'value, update=>'update'))  $result 表示受到影响的行数
$model->select(); 
$model->find();
$model->delete('pkeyid');
_________________________________________________________________________
CURD AR
$model = M('table'); $model->att = val; $model->add(无参数); $model->save(无参数)；$model->delete();
________________ 
$model->where()->limit()->.....
      ->field('字段1,字段2,字段3...')

开启跟踪信息	SHOW_PAGE_TRACE
APP_DEBUG => 调试模式(明确) 生产模式(模糊)

$model->getLastSql();$model-<_sql();获取模型中最后一条执行成功的语句
$model->fetchSql(true);

G(strat) G(end)
time =  G(strat, end,num/'m');

