using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using ScriptEngine.Machine;

namespace ScriptEngine.HostedScript.Library.LDAP
{
    /// <summary>
    /// Перечисление, определяющее возможные области поиска
    /// </summary>
    [EnumerationType("ОбластьПоиска", "SearchScope")]
    public enum SearchScopeImpl
    {
        /// <summary>
        /// Поиск только по базовому объекту
        /// </summary>
        [EnumItem("БазовыйОбъект", "Base")]
        Base,
        /// <summary>
        /// Поиск по непосредственным потомкам указанного корневого элемента
        /// </summary>
        [EnumItem("ОдинУровень", "OneLevel")]
        OneLevel,
        /// <summary>
        /// Поиск по всему поддереву
        /// </summary>
        [EnumItem("Дерево", "Subtree")]
        Subtree
    }

    /// <summary>
    /// Вспомогательный класс для конверсии перечисления Oscript в перечисление C# и обратно
    /// </summary>
    public static class SearchScopeConverter
    {

        /// <summary>
        /// Конвертирует значение Oscript в значение C#
        /// </summary>
        /// <param name="searchScope"></param>
        /// <returns></returns>
        public static SearchScope ToSearchScope(SearchScopeImpl searchScope)
        {
            switch (searchScope)
            {
                case SearchScopeImpl.Base:
                    return SearchScope.Base;
                case SearchScopeImpl.OneLevel:
                    return SearchScope.OneLevel;
                case SearchScopeImpl.Subtree:
                    return SearchScope.Subtree;
                default:
                    throw RuntimeException.InvalidArgumentType();

            }
        }

        /// <summary>
        /// Конвертирует значение C# в значение Oscript
        /// </summary>
        /// <param name="searchScope"></param>
        /// <returns></returns>
        public static SearchScopeImpl ToSearchScopeImpl(SearchScope searchScope)
        {
            switch (searchScope)
            {
                case SearchScope.Base:
                    return SearchScopeImpl.Base;
                case SearchScope.OneLevel:
                    return SearchScopeImpl.OneLevel;
                case SearchScope.Subtree:
                    return SearchScopeImpl.Subtree;
                default:
                    throw RuntimeException.InvalidArgumentType();

            }
        }
    }
}
