(function($) {
    $.fn.referencecontrol = function (source, args) {

        options = $.extend({}, defaults, options);

   


        function clearAttributes() {
            lblV11NumberTextBox.style.display = "none";
            lblV5CRefNoTextBox.style.display = "none";
            lblVrnTextBox.style.display = "none";
            lblV11NumberTextBox.closest("div").removeClass("validation");
            lblV5CRefNoTextBox.closest("div").removeClass("validation");
            lblV5C2RefNoTextBox.closest("div").removeClass("validation");
            lblVrnTextBox.closest("div").removeClass("validation");
        }
        function updateAttribute(lblControl, errorMessage) {
            lblControl.style.display = "inline";
            lblControl.closest("div").addClass("validation");
            source.errormessage = errorMessage;
        }


        function checkV11IsValid() {
            var v11Rgx = new RegExp("[0-9]{16}", "g");
            return v11NumberTextBox.value.match(v11Rgx);
        }
        function checkV5CIsValid() {
            var v5Crgx = new RegExp("[0-9]{11}", "g");
            return v5CRefNoTextBox.value.match(v5Crgx);
        }
        function checkV5C2IsValid() {
            var v5C2Rgx = new RegExp("[0-9]{12}", "g");
            return v5C2RefNoTextBox.value.match(v5C2Rgx);
        }
        function checkVrnIsValid() {
            var vrnrgx = new RegExp("^(([A-Za-z]{1,2}[ ]?[0-9]{1,4})|([A-Za-z]{3}[ ]?[0-9]{1,3})|([0-9]{1,3}[ ]?[A-Za-z]{3})|([0-9]{1,4}[ ]?[A-Za-z]{1,2})|([A-Za-z]{3}[ ]?[0-9]{1,3}[ ]?[A-Za-z])|([A-Za-z][ ]?[0-9]{1,3}[ ]?[A-Za-z]{3})|([A-Za-z]{2}[ ]?[0-9]{2}[ ]?[A-Za-z]{3})|([A-Za-z]{3}[ ]?[0-9]{4}))$", "g");
            return vrmTextBox.value.toUpperCase().match(vrnrgx);
        }

        function clientValidate(source, args) {
            var lblV11NumberTextBox = $('#<%=lblV11NumberTextBox.ClientId %>');
            var lblV5CRefNoTextBox = $('#<%=lblV5CRefNoTextBox.ClientId %>');
            var lblV5C2RefNoTextBox = $('#<%=lblV5C2RefNoTextBox.ClientId %>');
            var lblVrnTextBox = $('#<%=lblVrmTextBox.ClientId %>');

            var v11NumberTextBox = $('#<%=V11NumberTextBox.ClientId %>');
            var v5CRefNoTextBox = $('#<%=V5CRefNoTextBox.ClientId %>');
            var v5C2RefNoTextBox = $('#<%=V5C2RefNoTextBox.ClientId %>');
            var vrmTextBox = $('#<%=VrmTextBox.ClientId %>');

            var v11ErrorMessage = $('#<%=V11ErrorMessage.ClientId %>').val();
            var v5CErrorMessage = $('#<%=V5CErrorMessage.ClientId %>').val();
            var v5C2ErrorMessage = $('#<%=V5C2ErrorMessage.ClientId %>').val();
            var vrnErrorMessage = $('#<%=VRMErrorMessage.ClientId %>').val();

            args.IsValid = false;
            clearAttributes();

            if (checkV11IsValid()) {

                args.IsValid = true;

            } else if ($('#ExistingKeeperRadioButton').is(':checked') | $('#NewKeeperRadioButton').is(':checked')) {

                if ($('#ExistingKeeperRadioButton').is(':checked')) {

                    if (!checkV5CIsValid()) {
                        // Update attributes
                        updateAttribute(lblV5CRefNoTextBox, v5CErrorMessage);
                    } 
                    if (!checkVrnIsValid()) {
                        // Update attributes
                        updateAttribute(lblVrnTextBox, vrnErrorMessage);
                    }
                    args.IsValid = (checkV5CIsValid() && checkVrnIsValid());

                } else {

                    if (!checkV5C2IsValid()) {
                        // Update attributes
                        updateAttribute(v5C2ErrorMessage, v5C2ErrorMessage);
                    }
                    if (!checkVrnIsValid()) {
                        // Update attributes
                        updateAttribute(lblVrnTextBox, vrnErrorMessage);
                    }
                    args.IsValid = (checkV5C2IsValid() && checkVrnIsValid());  

                }

            } else if (!checkV11IsValid()) {

                args.IsValid = false;
                //Update attributes
                updateAttribute(lblVrnTextBox, v11ErrorMessage);

            }

        }
    }

    var defaults = {
        
    };
})(jQuery);