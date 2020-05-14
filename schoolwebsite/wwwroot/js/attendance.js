$(document).ready(function () {
    //var dataforpostmethod = absentdatafunction();
    $("#getdata").click(function () {
        $("#top").css("display", "block");
        $("#message").text("Loading Table...");
        $("#message2").text("Data saved Successfully");
        
        $.get("/Attendances/Index4",
            
            function (data) {
                           

                //console.log("received data "+data);
                //Here a checkbox creater block has been made to create a 31 elements of checkbox with name
                let checkboxwithnameid = (id) => {

                    var checkboxhtml = '';
                    for (i = 0; i < 31; i++) {
                        let identity = (data[j].id * 100 + i);
                        rowoftable = '<td>' + '<input type="checkbox" id="' + identity + '" name="' + identity + '" value="' + identity + '"></input>' + '</td>';
                        checkboxhtml += rowoftable;
                        console.log(identity);
                        //console.log(checkboxhtml);

                    }
                    $("#message").css("display", "none");
                    

                    
                    


                    //console.log(checkboxhtml);
                    return checkboxhtml;
                }

                // here we implemented the previous code as a function to send the whole table with checkbox
                let checkboxmaker = () => {

                    for (j = 0; j < data.length; j++) {
                        var htmlcontent = checkboxwithnameid(j);
                        markup = "<tr><td>" + data[j].name + "</td>" + htmlcontent + "</td></tr>";
                        tableBody = $("#tablebody");
                        tableBody.append(markup);

                    }


                }


                let idchecked = () => {

                    let initialarray = [];
                    for (j = 100; j <= (data.length * 100 + 30); j++) {
                        let tempid = '#' + j + '';

                        if ($(tempid).is(":checked")) {
                            let absentid = $(tempid).val();
                            console.log(absentid);
                            console.log('checked' + absentid);
                            initialarray.push(absentid);

                        }

                    }
                    console.log((initialarray));
                    
                    return initialarray;



                }


                //main absentdata
                let absentdatafunction = () => {
                    $("#submit").click(function () {
                        
                        let tempid = idchecked();
                        let finaljson = [];
                        
                        //console.log(tempid);
                        for (i = 0; i < tempid.length; i++) {
                            let tempdata = tempid[i];
                            let tempdataid = Math.floor(tempdata / 100);
                            console.log("temdataid" + tempdataid);
                            let tempdate = tempid[i] - tempdataid * 100;
                            tempdate = tempdate + 1;
                            console.log("tempdate" + tempdate);
                            let year = $("#year").val();
                            let month = $("#months").val();
                            //sentdata[i]["id"] = tempdataid;
                            //sentdata[i]["dateofabsent"] = '"' + month + " " + tempdate + 1 + " - " + year + '"';
                            finaljson.push({
                                Studentsid: tempdataid,
                                Absent:  month + " " + tempdate + " -" + year 
                            });


                        }
                        
                        
                        console.log(finaljson);



                        console.log("thirdstage started");
                       
                        for (var i = 0; i < finaljson.length; i++) {

                            var datajson = {
                                Studentsid: finaljson[i].Studentsid,
                                Absent: finaljson[i].Absent
                            }
                            $.post("Attendances/Indexdata",
                                {
                                    attendance: datajson
                                },
                                function (data, status) {
                                    console.log("Data- " + data);
                                    console.log("Status- " + status);
                                    $("#details").css("display", "block");
                                    
                                    $("#message2").css("display", "block");

                                    //testing settimeout function

                                    setTimeout(function () {
                                        $("#message2").css("display", "none");
                                    }, 2000);
                                });
                        }

                        /* right now commented for test
                        $.get("/Attendances/Success",

                            function (data, status) {
                                console.log("Success index--" + status);
                            });
                        */
                        
                        return finaljson;
                    });
                }

                checkboxmaker();

                absentdatafunction();

            });



    /*
        let getabsentdata = (jsondata) => jsondata;
        var dataforpostmethod = getabsentdata();
        console.log("thirdstage started");
        $.post("Attendances/Indexdata",
            {
                data:dataforpostmethod
            },
            function (data, status) {
                alert("Data: " + data + "\nStatus: " + status);
            });
    */

    });

});