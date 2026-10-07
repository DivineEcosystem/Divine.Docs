# <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride"></a> Class CMsgGCToServerCheerScalesOverride

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToServerCheerScalesOverride : IMessage<CMsgGCToServerCheerScalesOverride>, IEquatable<CMsgGCToServerCheerScalesOverride>, IDeepCloneable<CMsgGCToServerCheerScalesOverride>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToServerCheerScalesOverride](Divine.Protobufs.Dota2.CMsgGCToServerCheerScalesOverride.md)

#### Implements

IMessage<CMsgGCToServerCheerScalesOverride\>, 
[IEquatable<CMsgGCToServerCheerScalesOverride\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToServerCheerScalesOverride\>, 
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
[EnumerableExtensions.In<CMsgGCToServerCheerScalesOverride\>\(CMsgGCToServerCheerScalesOverride, params CMsgGCToServerCheerScalesOverride\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride__ctor"></a> CMsgGCToServerCheerScalesOverride\(\)

```csharp
public CMsgGCToServerCheerScalesOverride()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride__ctor_Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride_"></a> CMsgGCToServerCheerScalesOverride\(CMsgGCToServerCheerScalesOverride\)

```csharp
public CMsgGCToServerCheerScalesOverride(CMsgGCToServerCheerScalesOverride other)
```

#### Parameters

`other` [CMsgGCToServerCheerScalesOverride](Divine.Protobufs.Dota2.CMsgGCToServerCheerScalesOverride.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride_ScalesFieldNumber"></a> ScalesFieldNumber

```csharp
public const int ScalesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToServerCheerScalesOverride> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToServerCheerScalesOverride](Divine.Protobufs.Dota2.CMsgGCToServerCheerScalesOverride.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride_Scales"></a> Scales

```csharp
public RepeatedField<float> Scales { get; }
```

#### Property Value

 RepeatedField<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride_Clone"></a> Clone\(\)

```csharp
public CMsgGCToServerCheerScalesOverride Clone()
```

#### Returns

 [CMsgGCToServerCheerScalesOverride](Divine.Protobufs.Dota2.CMsgGCToServerCheerScalesOverride.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride_Equals_Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride_"></a> Equals\(CMsgGCToServerCheerScalesOverride\)

```csharp
public bool Equals(CMsgGCToServerCheerScalesOverride other)
```

#### Parameters

`other` [CMsgGCToServerCheerScalesOverride](Divine.Protobufs.Dota2.CMsgGCToServerCheerScalesOverride.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride_"></a> MergeFrom\(CMsgGCToServerCheerScalesOverride\)

```csharp
public void MergeFrom(CMsgGCToServerCheerScalesOverride other)
```

#### Parameters

`other` [CMsgGCToServerCheerScalesOverride](Divine.Protobufs.Dota2.CMsgGCToServerCheerScalesOverride.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerScalesOverride_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

