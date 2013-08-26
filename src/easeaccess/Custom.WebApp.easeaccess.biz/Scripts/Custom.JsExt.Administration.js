// Custom.JsExt.Administration.js
(function(){
Type.registerNamespace('Custom.Handlers');Custom.Handlers.ReflectionNode=function(){}
Custom.Handlers.ReflectionNode.path=function(node){var $0=node.raw;var $1=[];if($0.name){$1.add($0.name);}for(node=node.parentNode;node;node=node.parentNode){$0=node.raw;$1.add($0.name);}$1.reverse();return $1.join('/');}
Custom.Handlers.ReflectionTabsObject=function(){}
Custom.Handlers.ReflectionTabsObject.prototype={panel:null,application:null,area:null,files:null,file:null,lists:null,list:null,models:null,model:null,notes:null,note:null}
Custom.Handlers.ReflectionTreePanel=function(){Custom.Handlers.ReflectionTreePanel.initializeBase(this);}
Custom.Handlers.ReflectionTreePanel.prototype={itemClick:function(record,item,index,e,tabs){var $0=this;var $1=record.raw;switch($1.type){case 'application':tabs.application.show();tabs.application.getEl().dom.style.display='';tabs.area.show();tabs.files.hide();tabs.file.hide();tabs.lists.hide();tabs.list.hide();tabs.models.hide();tabs.model.hide();tabs.notes.hide();tabs.note.hide();tabs.application.setActive();break;case 'area':tabs.area.show();tabs.area.getEl().dom.style.display='';tabs.files.hide();tabs.file.hide();tabs.lists.hide();tabs.list.hide();tabs.models.hide();tabs.model.hide();tabs.notes.hide();tabs.note.hide();tabs.area.setActive();break;case 'files':tabs.files.show();tabs.files.getEl().dom.style.display='';tabs.files.setVisible(true);tabs.file.hide();tabs.lists.hide();tabs.list.hide();tabs.models.hide();tabs.model.hide();tabs.notes.hide();tabs.note.hide();tabs.files.setActive();break;case 'file':tabs.file.show();tabs.file.getEl().dom.style.display='';tabs.file.setVisible(true);tabs.lists.hide();tabs.list.hide();tabs.models.hide();tabs.model.hide();tabs.notes.hide();tabs.note.hide();tabs.file.setActive();break;case 'lists':tabs.files.hide();tabs.file.hide();tabs.lists.show();tabs.lists.getEl().dom.style.display='';tabs.lists.setVisible(true);tabs.list.hide();tabs.models.hide();tabs.model.hide();tabs.notes.hide();tabs.note.hide();tabs.lists.setActive();break;case 'list':tabs.files.hide();tabs.file.hide();tabs.list.show();tabs.list.getEl().dom.style.display='';tabs.list.setVisible(true);tabs.models.hide();tabs.model.hide();tabs.notes.hide();tabs.note.hide();tabs.list.setActive();break;case 'models':tabs.files.hide();tabs.file.hide();tabs.lists.hide();tabs.list.hide();tabs.models.show();tabs.models.getEl().dom.style.display='';tabs.models.setVisible(true);tabs.model.hide();tabs.notes.hide();tabs.note.hide();tabs.models.setActive();break;case 'model':tabs.files.hide();tabs.file.hide();tabs.lists.hide();tabs.list.hide();tabs.model.show();tabs.model.getEl().dom.style.display='';tabs.model.setVisible(true);tabs.notes.hide();tabs.note.hide();tabs.model.setActive();break;case 'notes':tabs.files.hide();tabs.file.hide();tabs.lists.hide();tabs.list.hide();tabs.models.hide();tabs.model.hide();tabs.notes.show();tabs.notes.getEl().dom.style.display='';tabs.notes.setVisible(true);tabs.notes.getEl().show();tabs.note.hide();tabs.notes.setActive();break;case 'note':tabs.files.hide();tabs.file.hide();tabs.lists.hide();tabs.list.hide();tabs.models.hide();tabs.model.hide();tabs.notes.hide();tabs.note.show();tabs.note.getEl().dom.style.display='block';tabs.note.setVisible(true);tabs.note.getEl().show();tabs.note.setActive();break;}tabs.panel.doLayout();},itemDbClick:function(record,item,index,e,tabs){var $0=this;var $1=record.raw;var $2=Ext.create('Ext.tab.Tab',{id:Custom.Handlers.ReflectionNode.path(record),title:$1.type});tabs.add($2);switch($1.type){case 'application':break;case 'area':break;case 'files':break;case 'file':break;case 'lists':break;case 'list':break;case 'models':break;case 'model':break;case 'notes':break;case 'note':break;}tabs.doLayout();}}
Custom.Handlers.ReflectionTreeProxy=function(){}
Custom.Handlers.ReflectionTreeProxy.prototype={buildUrl:function(request){var $0=Custom.Handlers.ReflectionNode.path(request.operation.node);var $1=request.operation.node.raw;return ($1.path)?$0+'/'+$1.path:$0;}}
Custom.Handlers.ReflectionNode.registerClass('Custom.Handlers.ReflectionNode');Custom.Handlers.ReflectionTabsObject.registerClass('Custom.Handlers.ReflectionTabsObject');Custom.Handlers.ReflectionTreePanel.registerClass('Custom.Handlers.ReflectionTreePanel',Ext.tree.Panel);Custom.Handlers.ReflectionTreeProxy.registerClass('Custom.Handlers.ReflectionTreeProxy');})();// This script was generated using Script# v0.7.4.0