/**
 * @license Copyright (c) 2003-2015, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see LICENSE.md or http://ckeditor.com/license
 */

CKEDITOR.editorConfig = function( config ) {
	// Define changes to default configuration here. For example:
	// config.language = 'fr';
    // config.uiColor = '#AADC6E';
    config.syntaxhighlight_lang = 'csharp';
    config.syntaxhighlight_hideControls = true;
    config.languages = 'vi';
    config.filebrowserBrowseUrl = '/scripts/ckfinder/ckfinder.html';
    config.filebrowserImageBrowseUrl = '/scripts/ckfinder/ckfinder.html?Types=Images';
    config.filebrowserFlashBrowseUrl = '/scripts/ckfinder/ckfinder.html?Types=Flash';
    config.filebrowserUploadUrl = '/scripts/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=File';
    config.filebrowserImageUploadUrl = '/Data';
    config.filebrowserFlashUploadUrl = '/scripts/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash';
    config.enterMode = CKEDITOR.ENTER_BR;
    config.width = "auto";
    config.height = "auto";

    CKFinder.setupCKEditor(null, '/scripts/ckfinder/');
};
