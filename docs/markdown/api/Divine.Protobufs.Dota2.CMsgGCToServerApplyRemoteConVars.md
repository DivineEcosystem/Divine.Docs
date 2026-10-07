# <a id="Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars"></a> Class CMsgGCToServerApplyRemoteConVars

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToServerApplyRemoteConVars : IMessage<CMsgGCToServerApplyRemoteConVars>, IEquatable<CMsgGCToServerApplyRemoteConVars>, IDeepCloneable<CMsgGCToServerApplyRemoteConVars>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToServerApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgGCToServerApplyRemoteConVars.md)

#### Implements

IMessage<CMsgGCToServerApplyRemoteConVars\>, 
[IEquatable<CMsgGCToServerApplyRemoteConVars\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToServerApplyRemoteConVars\>, 
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
[EnumerableExtensions.In<CMsgGCToServerApplyRemoteConVars\>\(CMsgGCToServerApplyRemoteConVars, params CMsgGCToServerApplyRemoteConVars\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars__ctor"></a> CMsgGCToServerApplyRemoteConVars\(\)

```csharp
public CMsgGCToServerApplyRemoteConVars()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars__ctor_Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars_"></a> CMsgGCToServerApplyRemoteConVars\(CMsgGCToServerApplyRemoteConVars\)

```csharp
public CMsgGCToServerApplyRemoteConVars(CMsgGCToServerApplyRemoteConVars other)
```

#### Parameters

`other` [CMsgGCToServerApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgGCToServerApplyRemoteConVars.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars_MsgFieldNumber"></a> MsgFieldNumber

```csharp
public const int MsgFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars_Msg"></a> Msg

```csharp
public CMsgApplyRemoteConVars Msg { get; set; }
```

#### Property Value

 [CMsgApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToServerApplyRemoteConVars> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToServerApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgGCToServerApplyRemoteConVars.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars_Clone"></a> Clone\(\)

```csharp
public CMsgGCToServerApplyRemoteConVars Clone()
```

#### Returns

 [CMsgGCToServerApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgGCToServerApplyRemoteConVars.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars_Equals_Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars_"></a> Equals\(CMsgGCToServerApplyRemoteConVars\)

```csharp
public bool Equals(CMsgGCToServerApplyRemoteConVars other)
```

#### Parameters

`other` [CMsgGCToServerApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgGCToServerApplyRemoteConVars.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars_"></a> MergeFrom\(CMsgGCToServerApplyRemoteConVars\)

```csharp
public void MergeFrom(CMsgGCToServerApplyRemoteConVars other)
```

#### Parameters

`other` [CMsgGCToServerApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgGCToServerApplyRemoteConVars.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerApplyRemoteConVars_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

