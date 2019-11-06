
$(document).ready(function() {
             $("p").hide();
    
               $("#heading1").mouseover(function() 
                                        {$("#hidden_first").show();});
               $("#heading1").mouseout(function()
                                       {$("#hidden_first").toggle();})
    
               $("#heading2").mouseover(function() 
                                        {$("#hidden_second").show();});
               $("#heading2").mouseout(function()
                                       {$("#hidden_second").toggle();})
    
               $("#heading3").mouseover(function() 
                                        {$("#hidden_third").show();});
               $("#heading3").mouseout(function()
                                       {$("#hidden_third").toggle();})
               });