/* 
    This file is for adding site-wide custom scripts 
*/

function hookup_charts(labels, colours, data) { 
    chart('pie', labels, colours, data);
    chart('doughnut', labels, colours, data);
    chart('line', labels, colours, data);
    chart('bar', labels, colours, data);
}
