﻿/**************************************************************************************************
*     File Name:               util.js
*     Assembly:                Budget Browser
*     Author:                  Terry D. Eppler
*     Created:                 03-24-2023
* 
*     Last Modified By:        Terry D. Eppler
*     Last Modified On:        05-31-2023
*
* <copyright file="util.js" company="Terry Eppler">
*    This is a Federal Budget, Finance, and Accounting application for the
*    US Environmental Protection Agency (US EPA).
*    Copyright ©  2023  Terry Eppler
* 
*    Permission is hereby granted, free of charge, to any person obtaining a copy
*    of this software and associated documentation files (the “Software”),
*    to deal in the Software without restriction,
*    including without limitation the rights to use,
*    copy, modify, merge, publish, distribute, sublicense,
*    and/or sell copies of the Software,
*    and to permit persons to whom the Software is furnished to do so,
*    subject to the following conditions:
* 
*    The above copyright notice and this permission notice shall be included in all
*    copies or substantial portions of the Software.
* 
*    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
*    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
*    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
*    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
*    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
*    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
*    DEALINGS IN THE SOFTWARE.
* 
*    You can contact me at: terryeppler@gmail.com or eppler.terry@epa.gov
* </copyright>
* <summary>
*   util.js
* </summary>
**************************************************************************************************/
(function() {
    "use strict";

    /**
     * Class for utility functions.
     * (credit -- https://github.com/CMU-CREATE-Lab/timemachine-viewer/blob/master/js/org/gigapan/util.js)
     * This class is used for functions that can be used across multiple applications.
     * @public
     * @class
     */
    const Util = function() {
        const navigatorUserAgent = navigator.userAgent;
        const isMSIEUserAgent = navigatorUserAgent.match(/MSIE|Trident|Edge/) != null;
        const isOperaUserAgent = navigatorUserAgent.match(/OPR/) != null;
        // The string "Chrome" is found in many user agents of browsers that are not truly Chrome
        var isChromeUserAgent = navigatorUserAgent.match(/Chrome/) != null && !isMSIEUserAgent && !isOperaUserAgent;
        var isSafariUserAgent = navigatorUserAgent.match(/Safari/) != null && !isChromeUserAgent && !isMSIEUserAgent;
        var isFirefoxUserAgent = navigatorUserAgent.match(/Firefox/) != null;

        /**
       * Parse and return variables in the format of a hash URL string.
       * @public
       * @returns {Object.<string, string>} - the query or hash parameters.
       */
        this.parseVars = function(str, keepNullOrUndefinedVars) {
            var vars = {};
            if (str) {
                const keyvals = str.split(/[#?&]/);
                for (let i = 0; i < keyvals.length; i++) {
                    const keyval = keyvals[i].split('=');
                    vars[keyval[0]] = keyval[1];
                }
            }
            // Delete keys with null/undefined values
            if (!keepNullOrUndefinedVars) {
                Object.keys(vars)
                    .forEach(function(key) {
                        return (vars[key] == null || key == "") && delete vars[key];
                    });
            }
            return vars;
        };

        /**
       * Resize a jQuery dialog to fit the screen.
       * @public
       * @param {Object} $dialog - a jQuery dialog object.
       */
        this.fitDialogToScreen = function($dialog) {
            const $window = $(window);
            $dialog.parent()
                .css({
                    "width": $window.width(),
                    "height": $window.height(),
                    "left": 0,
                    "top": 0
                });
            $dialog.dialog("option", "height", $window.height());
            $dialog.dialog("option", "width", $window.width());
        };

        /**
       * A helper for getting data safely with a default value.
       * @public
       * @param {*} v - the original value.
       * @param {*} defaultVal - the default value to return when the original one is undefined.
       * @returns {*} - the original value (if not undefined) or the default value.
       */
        var safeGet = function(v, defaultVal) {
            if (typeof defaultVal === "undefined") defaultVal = "";
            return (typeof v === "undefined") ? defaultVal : v;
        };
        this.safeGet = safeGet;

        /**
       * Scroll to an element's top position.
       * @public
       * @param {object} $element - a jQuery object to scroll to.
       * @param {number} [topMargin] - the top margin to reserve for scrolling.
       * @param {object} [$window] - a jQuery object that we want to scroll.
       */
        this.scrollTop = function($element, topMargin, $window) {
            topMargin = safeGet(topMargin, 0);
            $window = safeGet($window, $(window));
            const p = $element.offset();
            if (typeof p !== "undefined") {
                $window.scrollTop(Math.max(p.top - topMargin, 0));
            }
        };

        /**
       * Check if the browser is Firefox.
       * @public
       * @returns {boolean} - is Firefox or not.
       */
        this.isFirefox = function() {
            return isFirefoxUserAgent;
        };

        /**
       * Check if the browser is Safari.
       * @public
       * @returns {boolean} - is Safari or not.
       */
        this.isSafari = function() {
            return isSafariUserAgent;
        };

        /**
       * Check if the browser is Chrome.
       * @public
       * @returns {boolean} - is Chrome or not.
       */
        this.isChrome = function() {
            return isChromeUserAgent;
        };

        /**
       * Sort an array of dictionary objects by one key in place.
       * @public
       * @param {Object[]} array - array of dictionary objects.
       * @param {string} keyName - the key in the dictionary object to sort the array.
       */
        this.sortArrayOfDictByKeyInPlace = function(array, keyName) {
            array.sort(function(a, b) {
                const keyA = a[keyName];
                const keyB = b[keyName];
                if (keyA < keyB) return -1;
                if (keyA > keyB) return 1;
                return 0;
            });
        };

        /**
       * Sort the elements in an array randomly.
       * @public
       * @param {Object[]} array - array of objects.
       */
        this.shuffleArrayInPlace = function(array) {
            var currentIndex = array.length;
            if (typeof currentIndex === "undefined" || typeof array === "string") return array;
            var randomIndex;
            // While there remain elements to shuffle
            while (currentIndex != 0) {
                // Pick a remaining element
                randomIndex = Math.floor(Math.random() * currentIndex);
                currentIndex--;
                // And swap it with the current element
                [array[currentIndex], array[randomIndex]] = [array[randomIndex], array[currentIndex]];
            }
            return array;
        };
    };

    // Create the object and register it to window
    if (window.edaplotjs) {
        window.edaplotjs.Util = new Util();
    } else {
        window.edaplotjs = {};
        window.edaplotjs.Util = new Util();
    }
})();