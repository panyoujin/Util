﻿using System.Text;
using Util.Ui.Configs;
using Xunit;

namespace Util.Ui.NgZorro.Tests.DatePickers {
    /// <summary>
    /// 日期范围选择测试 - 表达式解析测试
    /// </summary>
    public partial class RangePickerTagHelperTest {
        /// <summary>
        /// 测试解析表达式属性for
        /// </summary>
        [Fact]
        public void TestFor_1() {
            _wrapper.SetExpression( t => t.Birthday );
            var result = new StringBuilder();
            result.Append( "<nz-form-item>" );
            result.Append( "<nz-form-label [nzRequired]=\"true\">出生日期</nz-form-label>" );
            result.Append( "<nz-form-control [nzErrorTip]=\"vt_id\">" );
            result.Append( "<nz-range-picker #v_id=\"xValidationExtend\" displayName=\"出生日期\" name=\"birthday\" " );
            result.Append( "x-validation-extend=\"\" [(ngModel)]=\"model.birthday\" [required]=\"true\">" );
            result.Append( "</nz-range-picker>" );
            result.Append( "<ng-template #vt_id=\"\">" );
            result.Append( "{{v_id.getErrorMessage()}}" );
            result.Append( "</ng-template>" );
            result.Append( "</nz-form-control>" );
            result.Append( "</nz-form-item>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试解析表达式属性for-begin,for-end
        /// </summary>
        [Fact]
        public void TestForBegin_ForEnd_1() {
            _wrapper.SetExpression( UiConst.ForBegin, t => t.BeginBirthday );
            _wrapper.SetExpression( UiConst.ForEnd, t => t.EndBirthday );
            var result = new StringBuilder();
            result.Append( "<nz-form-item>" );
            result.Append( "<nz-form-label [nzRequired]=\"true\">出生日期</nz-form-label>" );
            result.Append( "<nz-form-control [nzErrorTip]=\"vt_id\">" );
            result.Append( "<nz-range-picker #v_id=\"xValidationExtend\" #x_id=\"xRangePickerExtend\" " );
            result.Append( "displayName=\"出生日期\" name=\"beginBirthday\" x-range-picker-extend=\"\" x-validation-extend=\"\" " );
            result.Append( "[(beginDate)]=\"model.beginBirthday\" [(endDate)]=\"model.endBirthday\" [(ngModel)]=\"x_id.rangeDates\" [required]=\"true\">" );
            result.Append( "</nz-range-picker>" );
            result.Append( "<ng-template #vt_id=\"\">" );
            result.Append( "{{v_id.getErrorMessage()}}" );
            result.Append( "</ng-template>" );
            result.Append( "</nz-form-control>" );
            result.Append( "</nz-form-item>" );
            Assert.Equal( result.ToString(), GetResult() );
        }
    }
}