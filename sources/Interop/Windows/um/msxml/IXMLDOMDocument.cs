// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2933BF81-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMDocument : IXMLDOMNode")]
    [NativeInheritance("IXMLDOMNode")]
    public unsafe partial struct IXMLDOMDocument
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, uint>)(lpVtbl[1]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, uint>)(lpVtbl[2]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, uint*, int>)(lpVtbl[3]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_nodeName([NativeTypeName("BSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort**, int>)(lpVtbl[7]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_nodeValue(VARIANT* value)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT*, int>)(lpVtbl[8]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_nodeValue(VARIANT value)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT, int>)(lpVtbl[9]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_nodeType(DOMNodeType* type)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, DOMNodeType*, int>)(lpVtbl[10]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_parentNode(IXMLDOMNode** parent)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode**, int>)(lpVtbl[11]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_childNodes(IXMLDOMNodeList** childList)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNodeList**, int>)(lpVtbl[12]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_firstChild(IXMLDOMNode** firstChild)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode**, int>)(lpVtbl[13]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_lastChild(IXMLDOMNode** lastChild)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode**, int>)(lpVtbl[14]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode**, int>)(lpVtbl[15]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode**, int>)(lpVtbl[16]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNamedNodeMap**, int>)(lpVtbl[17]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int>)(lpVtbl[18]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[19]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[20]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[21]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, short*, int>)(lpVtbl[22]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMDocument**, int>)(lpVtbl[23]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, short, IXMLDOMNode**, int>)(lpVtbl[24]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort**, int>)(lpVtbl[25]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_text([NativeTypeName("BSTR *")] ushort** text)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort**, int>)(lpVtbl[26]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT put_text([NativeTypeName("BSTR")] ushort* text)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, int>)(lpVtbl[27]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, short*, int>)(lpVtbl[28]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT get_definition(IXMLDOMNode** definitionNode)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode**, int>)(lpVtbl[29]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_nodeTypedValue(VARIANT* typedValue)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT*, int>)(lpVtbl[30]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT put_nodeTypedValue(VARIANT typedValue)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT, int>)(lpVtbl[31]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT get_dataType(VARIANT* dataTypeName)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT*, int>)(lpVtbl[32]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, int>)(lpVtbl[33]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort**, int>)(lpVtbl[34]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode*, ushort**, int>)(lpVtbl[35]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT selectNodes([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNodeList** resultList)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMNodeList**, int>)(lpVtbl[36]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNode** resultNode)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMNode**, int>)(lpVtbl[37]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, short*, int>)(lpVtbl[38]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort**, int>)(lpVtbl[39]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort**, int>)(lpVtbl[40]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort**, int>)(lpVtbl[41]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode*, VARIANT, int>)(lpVtbl[42]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT get_doctype(IXMLDOMDocumentType** documentType)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMDocumentType**, int>)(lpVtbl[43]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), documentType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT get_implementation(IXMLDOMImplementation** impl)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMImplementation**, int>)(lpVtbl[44]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), impl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT get_documentElement(IXMLDOMElement** DOMElement)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMElement**, int>)(lpVtbl[45]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), DOMElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT putref_documentElement(IXMLDOMElement* DOMElement)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMElement*, int>)(lpVtbl[46]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), DOMElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT createElement([NativeTypeName("BSTR")] ushort* tagName, IXMLDOMElement** element)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMElement**, int>)(lpVtbl[47]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), tagName, element);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT createDocumentFragment(IXMLDOMDocumentFragment** docFrag)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMDocumentFragment**, int>)(lpVtbl[48]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), docFrag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT createTextNode([NativeTypeName("BSTR")] ushort* data, IXMLDOMText** text)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMText**, int>)(lpVtbl[49]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), data, text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT createComment([NativeTypeName("BSTR")] ushort* data, IXMLDOMComment** comment)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMComment**, int>)(lpVtbl[50]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), data, comment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT createCDATASection([NativeTypeName("BSTR")] ushort* data, IXMLDOMCDATASection** cdata)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMCDATASection**, int>)(lpVtbl[51]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), data, cdata);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT createProcessingInstruction([NativeTypeName("BSTR")] ushort* target, [NativeTypeName("BSTR")] ushort* data, IXMLDOMProcessingInstruction** pi)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, ushort*, IXMLDOMProcessingInstruction**, int>)(lpVtbl[52]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), target, data, pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT createAttribute([NativeTypeName("BSTR")] ushort* name, IXMLDOMAttribute** attribute)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMAttribute**, int>)(lpVtbl[53]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), name, attribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT createEntityReference([NativeTypeName("BSTR")] ushort* name, IXMLDOMEntityReference** entityRef)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMEntityReference**, int>)(lpVtbl[54]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), name, entityRef);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT getElementsByTagName([NativeTypeName("BSTR")] ushort* tagName, IXMLDOMNodeList** resultList)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMNodeList**, int>)(lpVtbl[55]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), tagName, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT createNode(VARIANT Type, [NativeTypeName("BSTR")] ushort* name, [NativeTypeName("BSTR")] ushort* namespaceURI, IXMLDOMNode** node)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT, ushort*, ushort*, IXMLDOMNode**, int>)(lpVtbl[56]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), Type, name, namespaceURI, node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT nodeFromID([NativeTypeName("BSTR")] ushort* idString, IXMLDOMNode** node)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMNode**, int>)(lpVtbl[57]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), idString, node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT load(VARIANT xmlSource, [NativeTypeName("VARIANT_BOOL *")] short* isSuccessful)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT, short*, int>)(lpVtbl[58]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), xmlSource, isSuccessful);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT get_readyState([NativeTypeName("long *")] int* value)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, int*, int>)(lpVtbl[59]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT get_parseError(IXMLDOMParseError** errorObj)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMParseError**, int>)(lpVtbl[60]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), errorObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT get_url([NativeTypeName("BSTR *")] ushort** urlString)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort**, int>)(lpVtbl[61]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), urlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT get_async([NativeTypeName("VARIANT_BOOL *")] short* isAsync)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, short*, int>)(lpVtbl[62]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isAsync);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT put_async([NativeTypeName("VARIANT_BOOL")] short isAsync)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, short, int>)(lpVtbl[63]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isAsync);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT abort()
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, int>)(lpVtbl[64]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT loadXML([NativeTypeName("BSTR")] ushort* bstrXML, [NativeTypeName("VARIANT_BOOL *")] short* isSuccessful)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, short*, int>)(lpVtbl[65]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), bstrXML, isSuccessful);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT save(VARIANT destination)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT, int>)(lpVtbl[66]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), destination);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT get_validateOnParse([NativeTypeName("VARIANT_BOOL *")] short* isValidating)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, short*, int>)(lpVtbl[67]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isValidating);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HRESULT put_validateOnParse([NativeTypeName("VARIANT_BOOL")] short isValidating)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, short, int>)(lpVtbl[68]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isValidating);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public HRESULT get_resolveExternals([NativeTypeName("VARIANT_BOOL *")] short* isResolving)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, short*, int>)(lpVtbl[69]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isResolving);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public HRESULT put_resolveExternals([NativeTypeName("VARIANT_BOOL")] short isResolving)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, short, int>)(lpVtbl[70]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isResolving);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public HRESULT get_preserveWhiteSpace([NativeTypeName("VARIANT_BOOL *")] short* isPreserving)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, short*, int>)(lpVtbl[71]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isPreserving);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        public HRESULT put_preserveWhiteSpace([NativeTypeName("VARIANT_BOOL")] short isPreserving)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, short, int>)(lpVtbl[72]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isPreserving);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public HRESULT put_onreadystatechange(VARIANT readystatechangeSink)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT, int>)(lpVtbl[73]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), readystatechangeSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        public HRESULT put_ondataavailable(VARIANT ondataavailableSink)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT, int>)(lpVtbl[74]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), ondataavailableSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public HRESULT put_ontransformnode(VARIANT ontransformnodeSink)
        {
            return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT, int>)(lpVtbl[75]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), ontransformnodeSink);
        }
    }
}
