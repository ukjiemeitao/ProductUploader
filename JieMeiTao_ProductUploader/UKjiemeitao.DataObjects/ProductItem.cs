﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKjiemeitao.DataObjects
{
    /// <summary>
    /// 淘宝API添加商品时用到对象，用于封装添加商品时需要用到的参数
    /// </summary>
    public partial class ProductItem
    {
        /// <summary>
        /// 必填 商品数量，取值范围:0-900000000的整数。且需要等于Sku所有数量的和。 拍卖商品中增加拍只能为1，荷兰拍要在[2,500)范围内。 
        /// </summary>
        public long? Num { get; set; }
        /// <summary>
        /// 必填 商品价格。取值范围:0-100000000;精确到2位小数;单位:元。如:200.07，表示:200元7分。需要在正确的价格区间内。 拍卖商品对应的起拍价。
        /// </summary>
        public string Price { get; set; }
        /// <summary>
        /// *必填 发布类型。可选值:fixed(一口价),auction(拍卖)。B商家不能发布拍卖商品，而且拍卖商品是没有SKU的。
        /// 拍卖商品发布时需要附加拍卖商品信息：拍卖类型(paimai_info.mode，拍卖类型包括三种：增价拍[1]，荷兰拍[2]以及降价拍[3])，商品数量(num)，起拍价(price)，价格幅度(increament)，保证金(paimai_info.deposit)。
        /// 另外拍卖商品支持自定义销售周期，通过paimai_info.valid_hour和paimai_info.valid_minute来指定。对于降价拍来说需要设置降价周期(paimai_info.interval)和拍卖保留价(paimai_info.reserve)。 注意：通过taobao.item.get接口获取拍卖信息时，会返回除了valid_hour和valid_minute之外的所有拍卖信息。 
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// *必填 新旧程度。可选值：new(新)，second(二手)，unused(闲置)。B商家不能发布二手商品。 如果是二手商品，特定类目下属性里面必填新旧成色属性 
        /// </summary>
        public string StuffStatus { get; set; }
        /// <summary>
        /// 必填 宝贝标题。不能超过30字符，受违禁词控制。天猫图书管控类目最大允许120字符； 
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 必填 宝贝描述。字数要大于5个字符，小于25000个字符，受违禁词控制 
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// 必填 所在地省份。如浙江，具体可以下载http://dl.open.taobao.com/sdk/商品城市列表.rar 取到 
        /// </summary>
        public string LocationState { get; set; }
        /// <summary>
        /// 必填 所在地城市。如杭州 。可以通过http://dl.open.taobao.com/sdk/商品城市列表.rar查询 
        /// </summary>
        public string LocationCity { get; set; }
        /// <summary>
        /// 商品上传后的状态。可选值:onsale(出售中),instock(仓库中);默认值:onsale 
        /// </summary>
        public string ApproveStatus { get; set; }
        /// <summary>
        /// 必填  叶子类目id 
        /// </summary>
        public long? Cid { get; set; }
        /// <summary>
        /// 商品属性列表。格式:pid:vid;pid:vid。属性的pid调用taobao.itemprops.get取得，属性值的vid用taobao.itempropvalues.get取得vid。 
        /// 如果该类目下面没有属性，可以不用填写。如果有属性，必选属性必填，其他非必选属性可以选择不填写.属性不能超过35对。
        /// 所有属性加起来包括分割符不能超过549字节，单个属性没有限制。 如果有属性是可输入的话，则用字段input_str填入属性的值
        /// </summary>
        public string Props { get; set; }
        /// <summary>
        /// 运费承担方式。可选值:seller（卖家承担）,buyer(买家承担);默认值:seller。
        /// 卖家承担不用设置邮费和postage_id.买家承担的时候，必填邮费和postage_id 如果用户设置了运费模板会优先使用运费模板，否则要同步设置邮费（post_fee,express_fee,ems_fee） 
        /// </summary>
        public string FreightPayer { get; set; }
        /// <summary>
        /// 有效期。可选值:7,14;单位:天;默认值:14 
        /// </summary>
        public long? ValidThru { get; set; }
        /// <summary>
        /// 是否有发票。可选值:true,false (商城卖家此字段必须为true);默认值:false(无发票) 
        /// </summary>
        public bool? HasInvoice { get; set; }
        /// <summary>
        /// 是否有保修。可选值:true,false;默认值:false(不保修) 
        /// </summary>
        public bool? HasWarranty { get; set; }
        /// <summary>
        /// 橱窗推荐。可选值:true,false;默认值:false(不推荐) 
        /// </summary>
        public bool? HasShowcase { get; set; }
        /// <summary>
        /// 商品所属的店铺类目列表。按逗号分隔。结构:",cid1,cid2,...,"，如果店铺类目存在二级类目，必须传入子类目cids。 
        /// </summary>
        public string SellerCids { get; set; }
        /// <summary>
        /// 支持会员打折。可选值:true,false;默认值:false(不打折)
        /// </summary>
        public bool? HasDiscount { get; set; }
        /// <summary>
        /// 平邮费用。取值范围:0.01-999.00;精确到2位小数;单位:元。如:5.07，表示:5元7分. 注:post_fee,express_fee,ems_fee需要一起填写 
        /// </summary>
        public string PostFee { get; set; }
        /// <summary>
        /// 快递费用。取值范围:0.01-999.00;精确到2位小数;单位:元。如:15.07，表示:15元7分 
        /// </summary>
        public string ExpressFee { get; set; }
        /// <summary>
        /// ems费用。取值范围:0.01-999.00;精确到2位小数;单位:元。如:25.07，表示:25元7分 
        /// </summary>
        public string EmsFee { get; set; }
        /// <summary>
        /// 定时上架时间。(时间格式：yyyy-MM-dd HH:mm:ss) 
        /// </summary>
        public DateTime? ListTime { get; set; }
        /// <summary>
        /// 加价(降价)幅度。如果为0，代表系统代理幅度。对于增价拍和荷兰拍来说是加价幅度，对于降价拍来说是降价幅度。 
        /// </summary>
        public string Increment { get; set; }
        /// <summary>
        /// 产品主图片路径 支持的文件类型：gif,jpg,jpeg,png 
        /// </summary>
        public string ImgFilePath { get; set; }
        /// <summary>
        /// 宝贝所属的运费模板ID。取值范围：整数且必须是该卖家的运费模板的ID（可通过taobao.delivery.template.get获得当前会话用户的所有邮费模板） 
        /// </summary>
        public long? PostageId { get; set; }
        /// <summary>
        /// 商品的积分返点比例。如:5,表示:返点比例0.5%. 
        /// 注意：返点比例必须是>0的整数，而且最大是90,即为9%.B商家在发布非虚拟商品时，返点必须是 5的倍数，即0.5%的倍数。其它是1的倍数，即0.1%的倍数。
        /// 无名良品商家发布商品时，复用该字段记录积分宝返点比例，返点必须是对应类目的返点步长的整数倍，默认是5，即0.5%。注意此时该字段值依旧必须是>0的整数，最高值不超过500，即50% 
        /// </summary>
        public long? AuctionPoint { get; set; }
        /// <summary>
        /// 属性值别名。如pid:vid:别名;pid1:vid1:别名1 ，其中：pid是属性id vid是属性值id。总长度不超过511字节 
        /// </summary>
        public string PropertyAlias { get; set; }
        /// <summary>
        /// 用户自行输入的类目属性ID串。结构："pid1,pid2,pid3"，如："20000"（表示品牌） 注：通常一个类目下用户可输入的关键属性不超过1个。 
        /// </summary>
        public string InputPids { get; set; }
        /// <summary>
        /// 更新的Sku的属性串，调用taobao.itemprops.get获取类目属性，如果属性是销售属性，再用taobao.itempropvalues.get取得vid。
        /// 格式:pid:vid;pid:vid,多个sku之间用逗号分隔。该字段内的销售属性（自定义的除外）也需要在props字段填写。
        /// sku的销售属性需要一同选取，如:颜色，尺寸。如果新增商品包含了sku，则此字段一定要传入。
        /// 这个字段的长度要控制在512个字节以内。 如果有自定义销售属性，则格式为pid:vid;pid2:vid2;$pText:vText , 其中$pText:vText为自定义属性。限制：其中$pText的’$’前缀不能少，且pText和vText文本中不可以存在冒号:和分号;以及逗号，
        /// </summary>
        public string SkuProperties { get; set; }
        /// <summary>
        /// Sku的数量串，结构如：num1,num2,num3 如：2,3
        /// </summary>
        public string SkuQuantities { get; set; }
        /// <summary>
        /// Sku的价格串，结构如：10.00,5.00,… 精确到2位小数;单位:元。如:200.07，表示:200元7分 
        /// </summary>
        public string SkuPrices { get; set; }
        /// <summary>
        /// Sku的外部id串，结构如：1234,1342,… sku_properties, sku_quantities, sku_prices, sku_outer_ids在输入数据时要一一对应，如果没有sku_outer_ids也要写上这个参数，入参是","(这个是两个sku的示列，逗号数应该是sku个数减1)；该参数最大长度是512个字节 
        /// </summary>
        public string SkuOuterIds { get; set; }
        /// <summary>
        /// 商品文字的字符集。繁体传入"zh_HK"，简体传入"zh_CN"，不传默认为简体 
        /// </summary>
        public string Lang { get; set; }
        /// <summary>
        /// 商品外部编码，该字段的最大长度是512个字节 
        /// </summary>
        public string OuterId { get; set; }
        /// <summary>
        /// 商品所属的产品ID(B商家发布商品需要用) 
        /// </summary>
        public long? ProductId { get; set; }
        /// <summary>
        /// 商品主图需要关联的图片空间的相对url。这个url所对应的图片必须要属于当前用户。
        /// pic_path和image只需要传入一个,如果两个都传，默认选择pic_path 
        /// </summary>
        public string PicPath { get; set; }
        /// <summary>
        /// 代充商品类型。在代充商品的类目下，不传表示不标记商品类型（交易搜索中就不能通过标记搜到相关的交易了）。
        /// 可选类型： no_mark(不做类型标记) time_card(点卡软件代充) fee_card(话费软件代充) 
        /// </summary>
        public string AutoFill { get; set; }
        /// <summary>
        /// 用户自行输入的子属性名和属性值，结构:"父属性值;一级子属性名;一级子属性值;二级子属性名;自定义输入值,....",
        /// 如：“耐克;耐克系列;科比系列;科比系列;2K5,Nike乔丹鞋;乔丹系列;乔丹鞋系列;乔丹鞋系列;json5”，多个自定义属性用','分割，
        /// input_str需要与input_pids一一对应，注：通常一个类目下用户可输入的关键属性不超过1个。所有属性别名加起来不能超过3999字节 
        /// </summary>
        public string InputStr { get; set; }
        /// <summary>
        /// 是否在淘宝上显示（如果传FALSE，则在淘宝主站无法显示该商品） 
        /// </summary>
        public bool? IsTaobao { get; set; }
        /// <summary>
        /// 是否在外店显示
        /// </summary>
        public bool? IsEx { get; set; }
        /// <summary>
        /// 是否是3D
        /// </summary>
        public bool? Is3D { get; set; }
        /// <summary>
        /// 是否承诺退换货服务!虚拟商品无须设置此项! 
        /// </summary>
        public bool? SellPromise { get; set; }
        /// <summary>
        /// 售后说明模板id 
        /// </summary>
        public long? AfterSaleId { get; set; }
        /// <summary>
        /// 此为货到付款运费模板的ID，对应的JAVA类型是long,如果COD卖家应用了货到付款运费模板，此值要进行设置。 
        /// </summary>
        public long? CodPostageId { get; set; }
        /// <summary>
        /// 实物闪电发货 
        /// </summary>
        public bool? IsLightningConsignment { get; set; }
        /// <summary>
        /// 商品的重量(商超卖家专用字段) 
        /// </summary>
        public long? Weight { get; set; }
        /// <summary>
        /// 商品是否为新品。只有在当前类目开通新品,并且当前用户拥有该类目下发布新品权限时才能设置is_xinpin为true，
        /// 否则设置true后会返回错误码:isv.invalid-permission:add-xinpin。
        /// 同时只有一口价全新的宝贝才能设置为新品，否则会返回错误码：isv.invalid-parameter:xinpin。
        /// 不设置该参数值或设置为false效果一致。
        /// </summary>
        public bool? IsXinpin { get; set; }
        /// <summary>
        /// 商品是否支持拍下减库存:1支持;2取消支持(付款减库存);0(默认)不更改 集市卖家默认拍下减库存; 商城卖家默认付款减库存 
        /// </summary>
        public long? SubStock { get; set; }
        /// <summary>
        /// 生产许可证号
        /// </summary>
        public string FoodSecurityPrdLicenseNo { get; set; }
        /// <summary>
        /// 产品标准号 
        /// </summary>
        public string FoodSecurityDesignCode { get; set; }
        /// <summary>
        /// 厂名 
        /// </summary>
        public string FoodSecurityFactory { get; set; }
        /// <summary>
        /// 厂址 
        /// </summary>
        public string FoodSecurityFactorySite { get; set; }
        /// <summary>
        /// 厂家联系方式 
        /// </summary>
        public string FoodSecurityContact { get; set; }
        /// <summary>
        /// 配料表
        /// </summary>
        public string FoodSecurityMix { get; set; }
        /// <summary>
        /// 储藏方法 
        /// </summary>
        public string FoodSecurityPlanStorage { get; set; }
        /// <summary>
        /// 保质期 
        /// </summary>
        public string FoodSecurityPeriod { get; set; }
        /// <summary>
        /// 食品添加剂 
        /// </summary>
        public string FoodSecurityFoodAdditive { get; set; }
        /// <summary>
        /// 供货商 
        /// </summary>
        public string FoodSecuritySupplier { get; set; }
        /// <summary>
        /// 生产开始日期，格式必须为yyyy-MM-dd 
        /// </summary>
        public string FoodSecurityProductDateStart { get; set; }
        /// <summary>
        /// 生产结束日期,格式必须为yyyy-MM-dd
        /// </summary>
        public string FoodSecurityProductDateEnd { get; set; }
        /// <summary>
        /// 进货开始日期，要在生产日期之后，格式必须为yyyy-MM-dd 
        /// </summary>
        public string FoodSecurityStockDateStart { get; set; }
        /// <summary>
        /// 进货结束日期，要在生产日期之后，格式必须为yyyy-MM-dd 
        /// </summary>
        public string FoodSecurityStockDateEnd { get; set; }
        /// <summary>
        /// 此参数暂时不起作用 
        /// </summary>
        public string SkuSpecIds { get; set; }
        /// <summary>
        /// 景区门票类宝贝发布时候，当卖家签订了支付宝代扣协议时候，需要选择支付方式：全额支付和订金支付。
        /// 当scenic_ticket_pay_way为1时表示全额支付，为2时表示订金支付 
        /// </summary>
        public long? ScenicTicketPayWay { get; set; }
        /// <summary>
        /// 景区门票在选择订金支付时候，需要交的预订费。传入的值是1到20之间的数值，小数点后最多可以保留两位（多余的部分将做四舍五入的处理）。
        /// 这个数值表示的是预订费的比例，最终的预订费为 scenic_ticket_book_cost乘一口价除以100 
        /// </summary>
        public string ScenicTicketBookCost { get; set; }
        /// <summary>
        /// 表示商品的体积，如果需要使用按体积计费的运费模板，一定要设置这个值。
        /// 该值的单位为立方米（m3），如果是其他单位，请转换成成立方米。
        /// 该值支持两种格式的设置：格式1：bulk:3,单位为立方米(m3),表示直接设置为商品的体积
        /// 。格式2：length:10;breadth:10;height:10，单位为米（m）。体积和长宽高都支持小数类型。
        /// 在传入体积或长宽高时候，不能带单位。体积的单位默认为立方米（m3），长宽高的单位默认为米(m)
        /// 该值支持两种格式的设置：格式1：bulk:3,单位为立方米(m3),表示直接设置为商品的体积。
        /// 格式2：length:10;breadth:10;height:10，单位为米（m）
        /// </summary>
        public string ItemSize { get; set; }
        /// <summary>
        /// 商品的重量，用于按重量计费的运费模板。注意：单位为kg。 只能传入数值类型（包含小数），不能带单位，单位默认为kg。 
        /// </summary>
        public string ItemWeight { get; set; }
        /// <summary>
        /// 商品基础色，数据格式为：pid:vid:rvid1,rvid2,rvid3;pid:vid:rvid1; 
        /// 基础色只支持以下14种颜色：28335//绿色 28338//蓝色 90554//桔色 28324//黄色 28341//黑色 28320//白色 28326//红色 28329//紫色 3232480//粉红色 107121//透明 132069//褐色 28332//浅灰色 3232478//深灰色 130164//花色 
        /// </summary>
        public string ChangeProp { get; set; }
        /// <summary>
        /// 商品卖点信息，最长15个字符。仅天猫商家可用
        /// </summary>
        public string SellPoint { get; set; }
        /// <summary>
        /// 商品描述模块化，模块列表，具体数据结构参见Item_Desc_Module。详细的使用方法可参考下面FAQ中说明。
        /// </summary>
        public string DescModules { get; set; }
        /// <summary>
        /// 健字号，保健品/膳食营养补充剂 这个类目下特有的信息，此类目下无需填写生产许可证编号（QS），如果填写了生产许可证编号（QS）将被忽略不保存；保存宝贝时，标题前会自动加上健字号产品名称一起作为宝贝标题； 
        /// </summary>
        public string FoodSecurityHealthProductNo { get; set; }
        /// <summary>
        /// 发布电子凭证宝贝时候表示是否使用邮寄 0: 代表不使用邮寄； 1：代表使用邮寄；如果不设置这个值，代表不使用邮寄 
        /// </summary>
        public string LocalityLifeChooseLogis { get; set; }
        /// <summary>
        /// 本地生活电子交易凭证业务，目前此字段只涉及到的信息为有效期; 如果有效期为起止日期类型，此值为2012-08-06,2012-08-16 如果有效期为【购买成功日 至】类型则格式为2012-08-16 如果有效期为天数类型则格式为15
        /// </summary>
        public string LocalityLifeExpirydate { get; set; }
        /// <summary>
        /// 网点ID 
        /// </summary>
        public string LocalityLifeNetworkId { get; set; }
        /// <summary>
        /// 码商信息，格式为 码商id:nick 
        /// </summary>
        public string LocalityLifeMerchant { get; set; }
        /// <summary>
        /// 核销打款 1代表核销打款 0代表非核销打款 
        /// </summary>
        public string LocalityLifeVerification { get; set; }
        /// <summary>
        /// 退款比例， 百分比%前的数字,1-100的正整数值 
        /// </summary>
        public long? LocalityLifeRefundRatio { get; set; }
        /// <summary>
        /// 电子凭证售中自动退款比例，百分比%前的数字，介于1-100之间的整数 
        /// </summary>
        public long? LocalityLifeOnsaleAutoRefundRatio { get; set; }
        /// <summary>
        /// 退款码费承担方。发布电子凭证宝贝的时候会增加“退款码费承担方”配置项，可选填：(1)s（卖家承担） (2)b(买家承担) 
        /// </summary>
        public string LocalityLifeRefundmafee { get; set; }
        /// <summary>
        /// 拍卖商品选择的拍卖类型，拍卖类型包括三种：增价拍(1)，荷兰拍(2)和降价拍(3)。 
        /// </summary>
        public long? PaimaiInfoMode { get; set; }
        /// <summary>
        /// 拍卖宝贝的保证金。对于增价拍和荷兰拍来说保证金有两种模式：淘宝默认模式（首次出价金额的10%），
        /// 自定义固定保证金（固定冻结金额只能输入不超过30万的正整数），并且保证金只冻结1次。
        /// 对于降价拍来说保证金只有淘宝默认的（竞拍价格的10% * 竞拍数量），并且每次出价都需要冻结保证金。
        /// 对于拍卖宝贝来说，保证金是必须的，但是默认使用淘宝默认保证金模式，只有用户需要使用自定义固定保证金的时候才需要使用到这个参数，如果该参数不传或传入0则代表使用默认。 
        /// </summary>
        public long? PaimaiInfoDeposit { get; set; }
        /// <summary>
        /// 降价拍宝贝的降价周期(分钟)。降价拍宝贝的价格每隔paimai_info.interval时间会下降一次increment。 
        /// </summary>
        public long? PaimaiInfoInterval { get; set; }
        /// <summary>
        /// 降价拍宝贝的保留价。对于降价拍来说，paimai_info.reserve必须大于0，且小于price-increment，而且（price-paimai_info.reserve）/increment的计算结果必须为整数 
        /// </summary>
        public string PaimaiInfoReserve { get; set; }
        /// <summary>
        /// 自定义销售周期的小时数。拍卖宝贝可以自定义销售周期，这里指定销售周期的小时数。注意，该参数只作为输入参数，不能通过taobao.item.get接口获取。 
        /// </summary>
        public long? PaimaiInfoValidHour { get; set; }
        /// <summary>
        /// 自定义销售周期的分钟数。拍卖宝贝可以自定义销售周期，这里是指定销售周期的分钟数。自定义销售周期的小时数。拍卖宝贝可以自定义销售周期，这里指定销售周期的小时数。
        /// 注意，该参数只作为输入参数，不能通过taobao.item.get接口获取。 
        /// </summary>
        public long? PaimaiInfoValidMinute { get; set; }
        /// <summary>
        /// 全球购商品采购地（库存类型）， 有两种库存类型：现货和代购 参数值为1时代表现货，值为2时代表代购。注意：使用时请与 全球购商品采购地（地区/国家）配合使用 
        /// </summary>
        public string GlobalStockType { get; set; }
        /// <summary>
        /// 全球购商品采购地（地区/国家）,默认值只在全球购商品采购地（库存类型选择情况生效），
        /// 地区国家值为（美国, 香港, 日本, 英国, 新西兰, 德国, 韩国, 荷兰, 澳洲, 法国, 意大利, 台湾, 澳门, 加拿大, 瑞士, 西班牙, 泰国, 新加坡, 马来西亚, 菲律宾, 其他） 
        /// </summary>
        public string GlobalStockCountry { get; set; }
        /// <summary>
        /// 商品数字ID，该参数必须(更新商品信息时必填)
        /// </summary>
        public long? NumIid { get; set; }
        /// <summary>
        /// 是否替换sku 
        /// </summary>
        public bool? IsReplaceSku { get; set; }
        /// <summary>
        /// 支持宝贝信息的删除,如需删除对应的食品安全信息中的储藏方法、保质期， 则应该设置此参数的值为：food_security.plan_storage,food_security.period; 各个参数的名称之间用【,】分割,
        /// 如果对应的参数有设置过值，即使在这个列表中，也不会被删除; 目前支持此功能的宝贝信息如下：
        /// 食品安全信息所有字段、电子交易凭证字段（locality_life，locality_life.verification，locality_life.refund_ratio，locality_life.network_id ，locality_life.onsale_auto_refund_ratio）。
        /// 支持对全球购宝贝信息的清除（字符串中包含global_stock） 
        /// </summary>
        public string EmptyFields { get; set; }
    }
}
