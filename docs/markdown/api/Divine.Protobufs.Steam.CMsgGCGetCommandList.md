# <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList"></a> Class CMsgGCGetCommandList

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGetCommandList : IMessage<CMsgGCGetCommandList>, IEquatable<CMsgGCGetCommandList>, IDeepCloneable<CMsgGCGetCommandList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGetCommandList](Divine.Protobufs.Steam.CMsgGCGetCommandList.md)

#### Implements

IMessage<CMsgGCGetCommandList\>, 
[IEquatable<CMsgGCGetCommandList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGetCommandList\>, 
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
[EnumerableExtensions.In<CMsgGCGetCommandList\>\(CMsgGCGetCommandList, params CMsgGCGetCommandList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList__ctor"></a> CMsgGCGetCommandList\(\)

```csharp
public CMsgGCGetCommandList()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList__ctor_Divine_Protobufs_Steam_CMsgGCGetCommandList_"></a> CMsgGCGetCommandList\(CMsgGCGetCommandList\)

```csharp
public CMsgGCGetCommandList(CMsgGCGetCommandList other)
```

#### Parameters

`other` [CMsgGCGetCommandList](Divine.Protobufs.Steam.CMsgGCGetCommandList.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_AppIdFieldNumber"></a> AppIdFieldNumber

```csharp
public const int AppIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_CommandPrefixFieldNumber"></a> CommandPrefixFieldNumber

```csharp
public const int CommandPrefixFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_AppId"></a> AppId

```csharp
public uint AppId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_CommandPrefix"></a> CommandPrefix

```csharp
public string CommandPrefix { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_HasAppId"></a> HasAppId

```csharp
public bool HasAppId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_HasCommandPrefix"></a> HasCommandPrefix

```csharp
public bool HasCommandPrefix { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGetCommandList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGetCommandList](Divine.Protobufs.Steam.CMsgGCGetCommandList.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_ClearAppId"></a> ClearAppId\(\)

```csharp
public void ClearAppId()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_ClearCommandPrefix"></a> ClearCommandPrefix\(\)

```csharp
public void ClearCommandPrefix()
```

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_Clone"></a> Clone\(\)

```csharp
public CMsgGCGetCommandList Clone()
```

#### Returns

 [CMsgGCGetCommandList](Divine.Protobufs.Steam.CMsgGCGetCommandList.md)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_Equals_Divine_Protobufs_Steam_CMsgGCGetCommandList_"></a> Equals\(CMsgGCGetCommandList\)

```csharp
public bool Equals(CMsgGCGetCommandList other)
```

#### Parameters

`other` [CMsgGCGetCommandList](Divine.Protobufs.Steam.CMsgGCGetCommandList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_MergeFrom_Divine_Protobufs_Steam_CMsgGCGetCommandList_"></a> MergeFrom\(CMsgGCGetCommandList\)

```csharp
public void MergeFrom(CMsgGCGetCommandList other)
```

#### Parameters

`other` [CMsgGCGetCommandList](Divine.Protobufs.Steam.CMsgGCGetCommandList.md)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCGetCommandList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

