﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BodeAbp.Product.Attributes.Domain;
using System.Collections.Generic;

namespace BodeAbp.Product.Attributes.Dtos
{
    /// <summary>
    /// 商品操作  属性Dto
    /// </summary>
    [AutoMap(typeof(ProductAttribute))]
    public class OperableAttributeDto : EntityDto
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public OperableAttributeDto()
        {
            attributeOptionIds = new List<string>();
            Options = new List<NameValueDto>();
        }

        /// <summary>
        /// 属性名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 提示
        /// </summary>
        public string Tips { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 属性选项Id（当属性类型为Switch时有效）
        /// </summary>
        public string attributeOptionId { get; set; }

        /// <summary>
        /// 属性选项Id集合（当属性类型为Multiple时有效）
        /// </summary>
        public ICollection<string> attributeOptionIds { get; set; }

        /// <summary>
        /// 选项（当属性类型为Switch/Multiple时有效）
        /// </summary>
        public ICollection<NameValueDto> Options { get; set; }

        /// <summary>
        /// 验证规则(正则表达式)
        /// </summary>
        public string ValidateRegular { get; set; }

        /// <summary>
        /// 分组名
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 是否必填项
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// 属性类型
        /// </summary>
        public ProductAttributeType AttributeType { get; set; }
    }

    /// <summary>
    /// 属性分组Dto
    /// </summary>
    public class OperableAttributeGroupDto
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public OperableAttributeGroupDto()
        {
            Attributes = new List<OperableAttributeDto>();
        }

        /// <summary>
        /// 分组名
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 属性集合
        /// </summary>
        public ICollection<OperableAttributeDto> Attributes { get; set; }
    }
}
