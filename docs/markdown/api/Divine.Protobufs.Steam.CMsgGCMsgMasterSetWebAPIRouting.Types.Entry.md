# <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry"></a> Class CMsgGCMsgMasterSetWebAPIRouting.Types.Entry

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCMsgMasterSetWebAPIRouting.Types.Entry : IMessage<CMsgGCMsgMasterSetWebAPIRouting.Types.Entry>, IEquatable<CMsgGCMsgMasterSetWebAPIRouting.Types.Entry>, IDeepCloneable<CMsgGCMsgMasterSetWebAPIRouting.Types.Entry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCMsgMasterSetWebAPIRouting.Types.Entry](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.Types.Entry.md)

#### Implements

IMessage<CMsgGCMsgMasterSetWebAPIRouting.Types.Entry\>, 
[IEquatable<CMsgGCMsgMasterSetWebAPIRouting.Types.Entry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCMsgMasterSetWebAPIRouting.Types.Entry\>, 
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
[EnumerableExtensions.In<CMsgGCMsgMasterSetWebAPIRouting.Types.Entry\>\(CMsgGCMsgMasterSetWebAPIRouting.Types.Entry, params CMsgGCMsgMasterSetWebAPIRouting.Types.Entry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry__ctor"></a> Entry\(\)

```csharp
public Entry()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry__ctor_Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_"></a> Entry\(Entry\)

```csharp
public Entry(CMsgGCMsgMasterSetWebAPIRouting.Types.Entry other)
```

#### Parameters

`other` [CMsgGCMsgMasterSetWebAPIRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.Types.md).[Entry](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.Types.Entry.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_InterfaceNameFieldNumber"></a> InterfaceNameFieldNumber

```csharp
public const int InterfaceNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_MethodNameFieldNumber"></a> MethodNameFieldNumber

```csharp
public const int MethodNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_RoutingFieldNumber"></a> RoutingFieldNumber

```csharp
public const int RoutingFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_HasInterfaceName"></a> HasInterfaceName

```csharp
public bool HasInterfaceName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_HasMethodName"></a> HasMethodName

```csharp
public bool HasMethodName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_InterfaceName"></a> InterfaceName

```csharp
public string InterfaceName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_MethodName"></a> MethodName

```csharp
public string MethodName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCMsgMasterSetWebAPIRouting.Types.Entry> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCMsgMasterSetWebAPIRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.Types.md).[Entry](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.Types.Entry.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_Routing"></a> Routing

```csharp
public CMsgGCRoutingInfo Routing { get; set; }
```

#### Property Value

 [CMsgGCRoutingInfo](Divine.Protobufs.Steam.CMsgGCRoutingInfo.md)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_ClearInterfaceName"></a> ClearInterfaceName\(\)

```csharp
public void ClearInterfaceName()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_ClearMethodName"></a> ClearMethodName\(\)

```csharp
public void ClearMethodName()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_Clone"></a> Clone\(\)

```csharp
public CMsgGCMsgMasterSetWebAPIRouting.Types.Entry Clone()
```

#### Returns

 [CMsgGCMsgMasterSetWebAPIRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.Types.md).[Entry](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.Types.Entry.md)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_Equals_Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_"></a> Equals\(Entry\)

```csharp
public bool Equals(CMsgGCMsgMasterSetWebAPIRouting.Types.Entry other)
```

#### Parameters

`other` [CMsgGCMsgMasterSetWebAPIRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.Types.md).[Entry](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.Types.Entry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_MergeFrom_Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_"></a> MergeFrom\(Entry\)

```csharp
public void MergeFrom(CMsgGCMsgMasterSetWebAPIRouting.Types.Entry other)
```

#### Parameters

`other` [CMsgGCMsgMasterSetWebAPIRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.Types.md).[Entry](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.Types.Entry.md)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Types_Entry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

