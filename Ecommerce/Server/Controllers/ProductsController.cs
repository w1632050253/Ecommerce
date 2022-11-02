﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>
    {
        new Product
        {
            Id = 1,
            Title = "Little Nemo",
            Description = "温瑟·麦凯（1867到1871年间的某一年出生，1934年逝世[a]）是一位多产的商业艺术家和漫画家，他于1904年开始在报纸上刊载漫画《罗彼特·芬德的梦》[b]，1905年开始连载的《小尼莫》是他的代表作[c][6]。1906年，麦凯开始从事杂耍表演，在观众面前现场表演粉笔独角戏[7]。",
            ImageURL = "https://tse4-mm.cn.bing.net/th/id/OIP-C.h-bG4w6crJYg_a0_8TXDXgHaLP?w=141&h=215&c=7&r=0&o=5&dpr=1.4&pid=1.7",
            price = 666

        },
        new Product
        {
            Id = 2,
            Title = "Freedom of Worship",
            Description = "《信仰自由》是诺曼·洛克威尔《四大自由》系列油画的第二幅。这四幅画的灵感源自第32任美国总统富兰克林·德拉诺·罗斯福1941年1月6日向第77届联邦国会发表的演说，演说中倡导的目标便是“四大自由”。",
            ImageURL = "https://tse4-mm.cn.bing.net/th/id/OIP-C.4xKEgKi7adbQk0yAb82JZgHaJl?w=189&h=245&c=7&r=0&o=5&dpr=1.4&pid=1.7",
            price = 10

        },
        new Product
        {
            Id = 3,
            Title = "Maus",
            Description = "情节从1978年的纽约开始，斯皮格曼聆听父亲弗拉德克谈论纳粹大屠杀期间的经历，为准备创作的《鼠族》收集素材。接下来书中根据这些经历从第二次世界大战前几年开始叙述，直至作者的父母从纳粹集中营解放。大部分情节围绕斯皮格曼和父亲之间的紧张关系展开，同时着重描绘20岁那年母亲自尽对作者的影响，弗拉德克悲痛欲绝并毁掉亡妻留下的奥斯威辛集中营回忆录。全书采用极简主义绘画风格，在节奏、结构和页面布局上颇有新意。",
            ImageURL = "https://tse4-mm.cn.bing.net/th/id/OIP-C.Bd2C8XgJ6Cegh6lRYiAd2QAAAA?w=120&h=180&c=7&r=0&o=5&dpr=1.4&pid=1.7",
            price = 999

        }
    };

        [HttpGet("GetProducts")]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(products);
        }
    }
}
