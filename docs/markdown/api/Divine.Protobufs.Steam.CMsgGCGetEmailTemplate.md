# <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate"></a> Class CMsgGCGetEmailTemplate

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGetEmailTemplate : IMessage<CMsgGCGetEmailTemplate>, IEquatable<CMsgGCGetEmailTemplate>, IDeepCloneable<CMsgGCGetEmailTemplate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGetEmailTemplate](Divine.Protobufs.Steam.CMsgGCGetEmailTemplate.md)

#### Implements

IMessage<CMsgGCGetEmailTemplate\>, 
[IEquatable<CMsgGCGetEmailTemplate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGetEmailTemplate\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CMsgGCGetEmailTemplate\>\(CMsgGCGetEmailTemplate, params CMsgGCGetEmailTemplate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate__ctor"></a> CMsgGCGetEmailTemplate\(\)

```csharp
public CMsgGCGetEmailTemplate()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate__ctor_Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_"></a> CMsgGCGetEmailTemplate\(CMsgGCGetEmailTemplate\)

```csharp
public CMsgGCGetEmailTemplate(CMsgGCGetEmailTemplate other)
```

#### Parameters

`other` [CMsgGCGetEmailTemplate](Divine.Protobufs.Steam.CMsgGCGetEmailTemplate.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_AppIdFieldNumber"></a> AppIdFieldNumber

```csharp
public const int AppIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_EmailFormatFieldNumber"></a> EmailFormatFieldNumber

```csharp
public const int EmailFormatFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_EmailLangFieldNumber"></a> EmailLangFieldNumber

```csharp
public const int EmailLangFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_EmailMsgTypeFieldNumber"></a> EmailMsgTypeFieldNumber

```csharp
public const int EmailMsgTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_AppId"></a> AppId

```csharp
public uint AppId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_EmailFormat"></a> EmailFormat

```csharp
public int EmailFormat { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_EmailLang"></a> EmailLang

```csharp
public int EmailLang { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_EmailMsgType"></a> EmailMsgType

```csharp
public uint EmailMsgType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_HasAppId"></a> HasAppId

```csharp
public bool HasAppId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_HasEmailFormat"></a> HasEmailFormat

```csharp
public bool HasEmailFormat { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_HasEmailLang"></a> HasEmailLang

```csharp
public bool HasEmailLang { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_HasEmailMsgType"></a> HasEmailMsgType

```csharp
public bool HasEmailMsgType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGetEmailTemplate> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGetEmailTemplate](Divine.Protobufs.Steam.CMsgGCGetEmailTemplate.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_ClearAppId"></a> ClearAppId\(\)

```csharp
public void ClearAppId()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_ClearEmailFormat"></a> ClearEmailFormat\(\)

```csharp
public void ClearEmailFormat()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_ClearEmailLang"></a> ClearEmailLang\(\)

```csharp
public void ClearEmailLang()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_ClearEmailMsgType"></a> ClearEmailMsgType\(\)

```csharp
public void ClearEmailMsgType()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_Clone"></a> Clone\(\)

```csharp
public CMsgGCGetEmailTemplate Clone()
```

#### Returns

 [CMsgGCGetEmailTemplate](Divine.Protobufs.Steam.CMsgGCGetEmailTemplate.md)

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_Equals_Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_"></a> Equals\(CMsgGCGetEmailTemplate\)

```csharp
public bool Equals(CMsgGCGetEmailTemplate other)
```

#### Parameters

`other` [CMsgGCGetEmailTemplate](Divine.Protobufs.Steam.CMsgGCGetEmailTemplate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_MergeFrom_Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_"></a> MergeFrom\(CMsgGCGetEmailTemplate\)

```csharp
public void MergeFrom(CMsgGCGetEmailTemplate other)
```

#### Parameters

`other` [CMsgGCGetEmailTemplate](Divine.Protobufs.Steam.CMsgGCGetEmailTemplate.md)

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCGetEmailTemplate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

