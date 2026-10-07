# <a id="Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars"></a> Class CMsgGCToClientApplyRemoteConVars

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientApplyRemoteConVars : IMessage<CMsgGCToClientApplyRemoteConVars>, IEquatable<CMsgGCToClientApplyRemoteConVars>, IDeepCloneable<CMsgGCToClientApplyRemoteConVars>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgGCToClientApplyRemoteConVars.md)

#### Implements

IMessage<CMsgGCToClientApplyRemoteConVars\>, 
[IEquatable<CMsgGCToClientApplyRemoteConVars\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientApplyRemoteConVars\>, 
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
[EnumerableExtensions.In<CMsgGCToClientApplyRemoteConVars\>\(CMsgGCToClientApplyRemoteConVars, params CMsgGCToClientApplyRemoteConVars\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars__ctor"></a> CMsgGCToClientApplyRemoteConVars\(\)

```csharp
public CMsgGCToClientApplyRemoteConVars()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars__ctor_Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars_"></a> CMsgGCToClientApplyRemoteConVars\(CMsgGCToClientApplyRemoteConVars\)

```csharp
public CMsgGCToClientApplyRemoteConVars(CMsgGCToClientApplyRemoteConVars other)
```

#### Parameters

`other` [CMsgGCToClientApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgGCToClientApplyRemoteConVars.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars_MsgFieldNumber"></a> MsgFieldNumber

```csharp
public const int MsgFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars_Msg"></a> Msg

```csharp
public CMsgApplyRemoteConVars Msg { get; set; }
```

#### Property Value

 [CMsgApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgApplyRemoteConVars.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientApplyRemoteConVars> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgGCToClientApplyRemoteConVars.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientApplyRemoteConVars Clone()
```

#### Returns

 [CMsgGCToClientApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgGCToClientApplyRemoteConVars.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars_Equals_Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars_"></a> Equals\(CMsgGCToClientApplyRemoteConVars\)

```csharp
public bool Equals(CMsgGCToClientApplyRemoteConVars other)
```

#### Parameters

`other` [CMsgGCToClientApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgGCToClientApplyRemoteConVars.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars_"></a> MergeFrom\(CMsgGCToClientApplyRemoteConVars\)

```csharp
public void MergeFrom(CMsgGCToClientApplyRemoteConVars other)
```

#### Parameters

`other` [CMsgGCToClientApplyRemoteConVars](Divine.Protobufs.Dota2.CMsgGCToClientApplyRemoteConVars.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientApplyRemoteConVars_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

